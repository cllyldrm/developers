using ExchangeRateUpdater.Clients.Cnb.Responses;

namespace ExchangeRateUpdater.Clients.Cnb;

public interface ICnbClient
{
    /// <summary>
    /// Gets exchange rates from defined client.
    /// </summary>
    /// <returns>An awaitable task of <see cref="ExchangeRatesResponse"/>.</returns>
    Task<ExchangeRatesResponse> GetExchangeRatesAsync();
}