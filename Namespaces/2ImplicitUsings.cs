using Shared.Enums;
using System;

namespace Shared.Dtos;

//turn implicitNamespaces on in project file and see what happens
//which namespaces are included relies on Project SDK type in project file
//change included namespace in itemgroup in project file
public record MyDtoBase(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue);
