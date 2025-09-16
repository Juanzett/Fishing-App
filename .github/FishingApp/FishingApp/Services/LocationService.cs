namespace FishingApp.Services;

public record struct LocationEntry(double Latitude, double Longitude, DateTimeOffset When);

public class LocationService
{
    private readonly List<LocationEntry> _entries = new();
    private readonly Random _rand = new();

    // Simulación: coordenadas alrededor de Buenos Aires
    private static readonly (double lat, double lng) Base = (-34.6037, -58.3816);

    public Task<LocationEntry> AddSimulatedAsync(CancellationToken ct = default)
    {
        // +/- ~0.05 grados ~5km aprox
        var lat = Base.lat + (_rand.NextDouble() - 0.5) * 0.1;
        var lng = Base.lng + (_rand.NextDouble() - 0.5) * 0.1;
        var entry = new LocationEntry(lat, lng, DateTimeOffset.Now);
        _entries.Insert(0, entry);
        return Task.FromResult(entry);
    }

    public IReadOnlyList<LocationEntry> GetAll() => _entries;
    public void Clear() => _entries.Clear();
}