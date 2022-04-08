using System;
using System.Collections.Generic;
using Delsoft.Calendars;

namespace Delsoft.Calendars.Test.Stubs;

internal class HolidaysCalendarStub : HolidaysCalendar<HolidaysCalendarStub>
{
    public static DateTime Holiday1Date = DateTime.Today.AddDays(1);
    public static string Holiday1Name = nameof(Holiday1Name);
    public static string Holiday1LocalName = nameof(Holiday1LocalName);
    
    public static DateTime Holiday2Date = DateTime.Today;
    public static string Holiday2Name = nameof(Holiday2Name);
    public static string Holiday2LocalName = nameof(Holiday2LocalName);
    
    public HolidaysCalendarStub()
    {
    }

    public HolidaysCalendarStub(int year) => Year = year;

    public Models.Holiday Holiday1 => new(date: Holiday1Date, name: Holiday1Name, localName: Holiday1LocalName);
    
    public Models.Holiday Holiday2 => new(date: Holiday2Date, name: Holiday2Name, localName: Holiday2LocalName);

    public override string[] GetCultures() => Array.Empty<string>();

    public override IEnumerable<Models.Holiday> GetAll() => Get(stub => stub.Holiday1, stub => stub.Holiday2);
}