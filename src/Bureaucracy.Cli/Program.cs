var org = Organization.Create("MyOrg")
    .With(Committee.Create("MyCommittee", frequency).MustApprove(Ticket.Type));

var worker = Worker.Create("MyWorker", org);
worker.CanComplete(Ticket.Type);
worker.JoinCommittee("MyCommittee");

var ticket = Ticket.Create<TicketType>();
org.RaiseTicket(ticket);

var project = Project.Create<ProjectType>("MyProject", noOfFeaures);
org.ProposeProject(project);

org.Simulate(logger);

var ticketResult = org.TicketResult();
var projectResult = org.ProjectResult();
var timeCard = worker.TimeCard();



