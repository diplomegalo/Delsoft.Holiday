﻿namespace Delsoft.Calendars.Test.Stubs;

internal class CalendarStub : BaseCalendar<HolidaysCalendarStub>
{
    public CalendarStub()
    {
    }

    public CalendarStub(int year) 
        : base(year)
    {
        
    }
}