using System;
using Xunit;

namespace Bureaucracy.Domain.Tests;

public class TicketTests
{
    [Fact]
    public void HasId()
    {
        var ticket = Ticket.Create();
        Assert.NotEqual(ticket.Id, Guid.Empty);
    }

    [Fact]
    public void 
}