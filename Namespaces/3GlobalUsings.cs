//using applied across the project
//advice: use separate file and create code guidelines on both implicit and global
//global using Shared.Enums;
using Shared.Enums;
using System;

namespace Shared.Dtos;

public record MyDtooBase(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue);
