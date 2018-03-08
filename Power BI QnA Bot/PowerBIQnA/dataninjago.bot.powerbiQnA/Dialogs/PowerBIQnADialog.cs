using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;
using System.Configuration;

namespace dataninjago.bot.powerbiQnA.Dialogs
{
    [Serializable]
    public class PowerBIQnADialog : QnAMakerDialog
    {
        public PowerBIQnADialog():base(
            new QnAMakerService(
                new QnAMakerAttribute(
                    ConfigurationManager.AppSettings["QnaSubscriptionKey"], 
                    ConfigurationManager.AppSettings["QnaKnowledgebaseId"],
                    "Sorry, couldn't find anything, please rephrase your question", 
                    0.5)
                )
            )
        {
        }

    }
}