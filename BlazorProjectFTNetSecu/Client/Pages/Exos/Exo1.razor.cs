using BlazorProjectFTNetSecu.Shared;

namespace BlazorProjectFTNetSecu.Client.Pages.Exos
{
    public partial class Exo1
    {

        List<Question> Questions { get; set; } = new List<Question>()
        {
            new Question
            {
                Enonce = "La terre est-elle ronde ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "La terre est-elle plate ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "Le ciel est-il bleu ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Le soleil est-il une étoile ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "La lune est-elle une planète ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "2 + 2 = 4 ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Python est-il un langage de programmation ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Le Japon est-il une île ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "La Russie est-elle le plus grand pays du monde ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "La neige est-elle chaude ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "Le poisson peut-il voler ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "Les humains peuvent-ils respirer sous l'eau ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "La France est-elle une république ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Les oiseaux ont-ils des dents ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "La glace est-elle faite d'eau ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "L'ordinateur fonctionne-t-il grâce à l'électricité ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "La musique a-t-elle un effet sur l'humeur ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Les poissons respirent-ils sous l'eau ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Le chien est-il un mammifère ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Le fer est-il un gaz ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "Le plastique est-il biodégradable ?",
                Reponse = false
            },
            new Question
            {
                Enonce = "La gravité maintient-elle les objets au sol ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Les plantes ont-elles besoin de lumière pour pousser ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "L'eau bout-elle à 100 degrés Celsius ?",
                Reponse = true
            },
            new Question
            {
                Enonce = "Le soleil tourne-t-il autour de la terre ?",
                Reponse = false
            },
        };

        public bool QuestionnaireFini 
        {
            get
            {
                return Questions.Count <= QuestionActuelle;
            } 
        }

        public int BonnesReponses { get; set; }

        public int QuestionActuelle { get; set; } = 0;

        void RecevoirReponse(bool resultat)
        {
            if (resultat)
            {
                BonnesReponses++;
            }

            NextQuestion();
        }

        void NextQuestion()
        {
            QuestionActuelle++;
        }

        void RestartGame()
        {
            QuestionActuelle = 0; 
            BonnesReponses = 0;
        }

    }
}
