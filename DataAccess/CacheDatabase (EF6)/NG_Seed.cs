using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class NG_Seed
    {
        public static void Data(NgDbEntities context)
        {
            #region OLD DATA
            //HashSet<CFGApplication> defualtProjects = new HashSet<CFGApplication>();

            //var KD = new Employee() { FullName = "Kumar Dhiraj", PUID = "DJ1C", EmailID = "", JobTitle = "SeniorTechnicalLead" };
            //context.Employees.Add(KD);
            //var HY = new Employee() { FullName = "Helene Youx", PUID = "HY9U", EmailID = "", JobTitle = "BusinessAnalyst" };
            //context.Employees.Add(HY);
            //var MH = new Employee() { FullName = "Michael Herve", PUID = "MH7T", EmailID = "", JobTitle = "BusinessAnalyst" };
            //context.Employees.Add(MH);
            //var GV = new Employee() { FullName = "Gorrepati Vinay", PUID = "GV3R", EmailID = "", JobTitle = "SoftwareEngineer" };
            //context.Employees.Add(GV);
            //var SK = new Employee() { FullName = "Sayak Kundu", PUID = "SK0U", EmailID = "", JobTitle = "SoftwareEngineer" };
            //context.Employees.Add(SK);
            //var PT = new Employee() { FullName = "Prem T G", PUID = "PT7G", EmailID = "", JobTitle = "QATester" };
            //context.Employees.Add(PT);
            //var LR = new Employee() { FullName = "Ludovic Richard", PUID = "LR5T", EmailID = "", JobTitle = "BusinessAnalyst" };
            //context.Employees.Add(LR);
            //var AS = new Employee() { FullName = "Abhinav Somal", PUID = "AS8M", EmailID = "", JobTitle = "SoftwareEngineer" };
            //context.Employees.Add(AS);
            //var ASK = new Employee() { FullName = "Arun Selva Kumar", PUID = "AS4K", EmailID = "", JobTitle = "SoftwareEngineer" };
            //context.Employees.Add(ASK);
            //var SS = new Employee() { FullName = "Shaktimayee Swain", PUID = "SS6S", EmailID = "", JobTitle = "QATester" };
            //context.Employees.Add(SS);
            //var LB = new Employee() { FullName = "Lokesh B", PUID = "DN5W", EmailID = "", JobTitle = "SoftwareEngineer" };
            //context.Employees.Add(LB);
            //var PN = new Employee() { FullName = "Pramiti Narkhede", PUID = "PN9E", EmailID = "", JobTitle = "QATester" };
            //context.Employees.Add(PN);
            //var IG = new Employee() { FullName = "Indranil Ghosh", PUID = "IG0H", EmailID = "", JobTitle = "QATester" };
            //context.Employees.Add(IG);

            //var some = new CFGApplication()
            //{
            //    TeamName = "CuPS",
            //    ProjectName = "ACF",
            //    Query = new Query() { Troubleshoot = "PBI/Tasks involving external team dependency like Tools Team, should have a better execution plan to avoid last minute hurry", Resolution = "During the refinement, identify all the external dependencies and address them on priority." },
            //    Employees = { KD, MH, HY, GV, SK, PT }
            //};
            //defualtProjects.Add(some);

            //var some1 = new CFGApplication()
            //{
            //    TeamName = "CuPS",
            //    ProjectName = "ARC",
            //    Query = new Query() { Troubleshoot = "Adhere to ETA's. ETA's to be updated on PBI's / Bug.", Resolution = "Plan for Rework which will help developers to provide an more real ETA" },
            //    Employees = { KD, HY, LR, AS, ASK, SS }
            //};
            //defualtProjects.Add(some1);

            //var some2 = new CFGApplication()
            //{
            //    TeamName = "CuPS",
            //    ProjectName = "QTV",
            //    Query = new Query() { Troubleshoot = "Not intimating the Impediments / Tech Challenge on time", Resolution = null },
            //    Employees = { KD, HY, MH, SK, LB, PN }
            //};
            //defualtProjects.Add(some2);

            //var some3 = new CFGApplication()
            //{
            //    TeamName = "CuPS",
            //    ProjectName = "SaC",
            //    Query = new Query() { Troubleshoot = "UI Functioncal Bug", Resolution = "Need to Discuss together with BA's to come up with idea to split the PBI's for future" },
            //    Employees = { MH, SK, IG }
            //};
            //defualtProjects.Add(some3);

            //var some4 = new CFGApplication()
            //{
            //    TeamName = "CuPS",
            //    ProjectName = "SFCR",
            //    Query = new Query() { Troubleshoot = "​Sprint planning need to be improveD", Resolution = "Tasks for the PBI and Tasks should have not more than 6 hours for each task" },
            //    Employees = { LR, LB, PN }
            //};
            //defualtProjects.Add(some4);

            //var some5 = new CFGApplication()
            //{
            //    TeamName = "ARC ",
            //    ProjectName = "ADR",
            //    Query = new Query() { Troubleshoot = "​Knowledge on some applications is limited to some QAs/ Devs.", Resolution = "Another Session for Training on Homologa is needed for testers." },
            //    Employees = { KD, HY, MH, SK, LB, PN }
            //};
            //defualtProjects.Add(some5);

            //var some6 = new CFGApplication()
            //{
            //    TeamName = "ARC ",
            //    ProjectName = "R3",
            //    Query = new Query() { Troubleshoot = "Participation in scrum ceremonies", Resolution = "All scrum team members to participate actively in all the scrum ceremonies" },
            //    Employees = { KD, HY, MH, SK, LB, PN }
            //};
            //defualtProjects.Add(some6);

            //var some7 = new CFGApplication()
            //{
            //    TeamName = "ARC ",
            //    ProjectName = "CTF",
            //    Query = new Query() { Troubleshoot = "Validation of Fitnesse test cases", Resolution = "​Fitnesse cases to be validated by QAs" },
            //    Employees = { MH, SK, IG }
            //};
            //defualtProjects.Add(some7);

            //context.CFGApplications.AddRange(defualtProjects);
            #endregion

            #region NEW DATA
            var defualtTeams = new HashSet<Team>();
            defualtTeams.Add(new Team()
            {
                TeamID = Guid.NewGuid(),
                TeamName = "CFG-CuPS",
                TeamStatus = 1,
                Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "ACF", ProjectStatus = 1 },
                                                                                                                                           new Project() { ProjectID = Guid.NewGuid(), ProjectName = "AFR", ProjectStatus = 1 },
                                                                                                                                           new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SaC", ProjectStatus = 1 },
                                                                                                                                           new Project() { ProjectID = Guid.NewGuid(), ProjectName = "QTV", ProjectStatus = 1 },
                                                                                                                                           new Project() { ProjectID = Guid.NewGuid(), ProjectName = "CTF", ProjectStatus = 1 },
                                                                                                                                           new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SFCR", ProjectStatus = 1 }}
            });
            defualtTeams.Add(new Team()
            {
                TeamID = Guid.NewGuid(),
                TeamName = "CFG-ARC",
                TeamStatus = 1,
                Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "ADR", ProjectStatus = 1 },
                                                                                                                                          new Project() { ProjectID = Guid.NewGuid(), ProjectName = "Homologa", ProjectStatus = 0 } }
            });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "CFG-A", TeamStatus = 0 });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "CFG-B", TeamStatus = 0 });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "CFG-C", TeamStatus = 0 });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "SVR", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SVR", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "IPW-Team-A", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "IPW-Team-A", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "IPW-Team-B", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "IPW-Team-B", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "IPW-Team-S", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "IPW-Team-S", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "CL-AP", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "CL-AP", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "CL-MB", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "CL-MB", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "ICRV", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "ICRV", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "SAM", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SAM", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "SCP", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SCP", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "SSR", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "SSR", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "TBSS", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "TBSS", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "XP", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "XP", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "UX", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "UX", ProjectStatus = 1 } } });
            defualtTeams.Add(new Team() { TeamID = Guid.NewGuid(), TeamName = "Pesticides", TeamStatus = 1, Project = new List<Project>(1) { new Project() { ProjectID = Guid.NewGuid(), ProjectName = "Pesticides", ProjectStatus = 1 } } });
            #endregion
            context.Teams.AddRange(defualtTeams);
            context.SaveChanges();
            System.Console.WriteLine("UpLoaded !");
        }
    }
}