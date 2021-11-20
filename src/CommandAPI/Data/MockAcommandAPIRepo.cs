using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockAcommandAPIRepo : ICommandAPIRepo
    {

        bool ICommandAPIRepo.SaveChanges()
        {
            throw new System.NotImplementedException();
        }
        void ICommandAPIRepo.CreateCommad()
        {
            throw new System.NotImplementedException();
        }

        void ICommandAPIRepo.DeleteCommand()
        {
            throw new System.NotImplementedException();
        }
        void ICommandAPIRepo.UpdateCommand()
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<CommandsModel> ICommandAPIRepo.GetAllCommands()
        {
            var commands = new List<CommandsModel>
            {
                new CommandsModel{
                    Id=1,
                    HowTo ="Howto1",
                    CommandLine="Commandline1",
                    Platform="Platform1"
                },
                new CommandsModel{
                    Id=2,
                    HowTo ="Howto2",
                    CommandLine="Commandline2",
                    Platform="Platform2"
                }
            };
            return commands;
        }
        

        CommandsModel ICommandAPIRepo.GetCommandByID()
        {
            return new CommandsModel{
                    Id=2,
                    HowTo ="Howto2",
                    CommandLine="Commandline2",
                    Platform="Platform2"
            };
        }

    }
}