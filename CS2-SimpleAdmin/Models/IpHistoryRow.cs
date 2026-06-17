namespace CS2_SimpleAdmin.Models;

public record IpHistoryRow(ulong Steamid, string? Name, uint Address, DateTime Used_at);
