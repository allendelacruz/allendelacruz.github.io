using allendelacruz.github.io.Common.Interfaces;
using System;

namespace allendelacruz.github.io.Common.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now => DateTime.Now;
    }
}