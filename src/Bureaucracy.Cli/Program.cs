//var org = Organization.Create("MyOrg")
//    .With(Committee.Create("MyCommittee", frequency).MustApprove(Ticket.Type));

//var worker = Worker.Create("MyWorker", org);
//worker.CanComplete(Ticket.Type);
//worker.JoinCommittee("MyCommittee");

//var ticket = Ticket.Create<TicketType>();
//org.RaiseTicket(ticket);

//var project = Project.Create<ProjectType>("MyProject", noOfFeatures);
//org.ProposeProject(project);

//org.Simulate(logger);

//var ticketResult = org.TicketResult();
//var projectResult = org.ProjectResult();
//var timeCard = worker.TimeCard();

// Single Feature New WebApp Project Workflow
// Idea Occurred
// Idea posted (owner, 1 hours)
// Feature planned (BA, 4 hours)
// Architecture planned (architect, 2 hours)
// Acceptance tests written (owner + tester, 7 hours)
// Architecture created - dev (ops, 2 hours)
// Feature developed (dev team, 56 hours - min 14 hours)
// Architecture created - sys test (ops, 2 hours)
// Feature deployed to sys test environment (dev, 1 hour)
// Feature tested - sys test (test, 2 hours)
// Architecture created - uat (ops, 2 hours)
// Feature deployed to uat environment (dev, 1 hour)
// Feature tested - uat (owner, 4 hours)
// Architecture created - prod (ops, 2 hours)
// Feature deployed to prod (ops, 1 hour)

// var org = Organization.Create("MyOrg");
// Any team without required skill set raises a ticket
// var devTeam = Team.CreateTeam("MyDevTeam");
// var dev = Worker.CreateSoftwareEngineer("MyDev1");
// dev.JoinTeam(devTeam);
// org.AddTeam(devTTeam);
// etc...

// var project = owner.NewWebApp("MyApp");
// org.ProposeProject(project);



