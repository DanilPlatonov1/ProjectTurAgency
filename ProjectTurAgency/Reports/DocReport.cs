using Microsoft.Extensions.Logging;
using ProjectTurAgency.Entity;
using ProjectTurAgency.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTurAgency.Reports;

internal class DocReport
{
    private readonly IClientRepository _clientRepository;
    private readonly IRouteRepository _routeRepository;
    private readonly ITourRepository _tourRepository;
    private readonly ILogger<DocReport> _logger;

    public DocReport(
        IClientRepository clientRepository,
        IRouteRepository routeRepository,
        ITourRepository tourRepository,
        ILogger<DocReport> logger)
    {
        _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
        _routeRepository = routeRepository ?? throw new ArgumentNullException(nameof(routeRepository));
        _tourRepository = tourRepository ?? throw new ArgumentNullException(nameof(tourRepository));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public bool CreateDoc(
        string filePath,
        bool includeClients,
        bool includeRoutes,
        bool includeTours)
    {
        try
        {
            var word = new WordBuilder(filePath)
                .AddHeader("Отчёт по данным Туристического Агентства")
                .AddParagraph($"Дата формирования: {DateTime.Now:dd.MM.yyyy HH:mm}");

            if (includeClients)
            {
                var clients = GetClients();
                word.AddHeader("\nКлиенты");
                if (clients.Count > 1)
                    word.AddTable([1000, 3000, 3000, 3000], clients);
                else
                    word.AddParagraph("Данные о клиентах отсутствуют.");
            }

            if (includeRoutes)
            {
                var routes = GetRoutes();
                word.AddHeader("\nМаршруты");
                if (routes.Count > 1)
                    word.AddTable([1000, 4000, 4000], routes);
                else
                    word.AddParagraph("Данные о маршрутах отсутствуют.");
            }

            if (includeTours)
            {
                var tours = GetTours();
                word.AddHeader("\nТуры");
                if (tours.Count > 1)
                    word.AddTable([1000, 4000], tours);
                else
                    word.AddParagraph("Данные о турах отсутствуют.");
            }

            word.Build();

            _logger.LogInformation("Отчёт успешно создан: {FilePath}", filePath);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при создании отчёта Word.");
            return false;
        }
    }

    private List<string[]> GetClients()
    {
        var clientsData = _clientRepository
            .ReadClients()
            .Select(x => new string[]
            {
            x.FullName,
            x.ClientSex.ToString(),
            x.Phone,
            x.Email
            })
            .ToList();

        clientsData.Insert(0, new string[] { "ФИО", "Пол", "Телефон", "Почта" });

        return clientsData;
    }

    private List<string[]> GetRoutes()
    {
        var routesData = _routeRepository
            .ReadRoutes()
            .Select(x => new string[]
            {
            x.StartPoint,
            x.EndPoint,
            x.DurationDays.ToString()
            })
            .ToList();

        routesData.Insert(0, new string[] { "Начальная точка", "Конечная точка", "Продолжительность" });
        return routesData;
    }

    private List<string[]> GetTours()
    {
        var toursData = _tourRepository
            .ReadTours()
            .Select(x => new string[]
            {
            x.Name,
            x.Price.ToString()
            })
            .ToList();

        toursData.Insert(0, new string[] { "Название", "Цена" });
        return toursData;
    }

}
