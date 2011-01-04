﻿using Machine.Specifications;
using YouTrackSharp.Issues;
using YouTrackSharp.Projects;

namespace YouTrackSharp.Specs.Helpers
{
    public class AuthenticatedYouTrackServerForProjectSpecsSetup : AuthenticatedYouTrackServerSetup
    {
        Establish context = () =>
        {
            ProjectManagement = new ProjectManagement(Server.Connection);
        };

        protected static ProjectManagement ProjectManagement;
    }
}