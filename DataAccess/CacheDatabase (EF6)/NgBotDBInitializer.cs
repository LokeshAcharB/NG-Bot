using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccess
{
    class NgBotDBInitializer : DropCreateDatabaseIfModelChanges<NgDbEntities>
    {
        protected override void Seed(NgDbEntities context)
        {
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
            context.Teams.AddRange(defualtTeams);
            base.Seed(context);
        }
    }
}
