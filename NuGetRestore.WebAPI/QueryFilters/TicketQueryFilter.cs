﻿namespace NuGetRestore.WebAPI.QueryFilters
{
    public class TicketQueryFilter
    {
        public int? Id { get; set; }
        public string TitleOrDescription { get; set; }
    }
}
