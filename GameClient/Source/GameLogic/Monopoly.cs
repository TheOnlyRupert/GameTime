using System;
using System.Collections.Generic;

namespace GameClient.Source.GameLogic {
    //server
    public class Monopoly {
        private static readonly Random rng = new Random();
        private readonly List<int> ChanceCardsList = new List<int>();
        private readonly List<int> ChestCardsList = new List<int>();

        public Monopoly() {
            ChanceCardsList.Add(0);
            ChanceCardsList.Add(1);
            ChanceCardsList.Add(2);
            ChanceCardsList.Add(3);
            ChanceCardsList.Add(4);
            ChanceCardsList.Add(4); // yes its dupe this on purpose
            ChanceCardsList.Add(5);
            ChanceCardsList.Add(6);
            ChanceCardsList.Add(7);
            ChanceCardsList.Add(8);
            ChanceCardsList.Add(9);
            ChanceCardsList.Add(10);
            ChanceCardsList.Add(11);
            ChanceCardsList.Add(12);
            ChanceCardsList.Add(13);
            ChanceCardsList.Add(14);
            ChanceCardsList.Add(15);

            ChestCardsList.Add(0);
            ChestCardsList.Add(1);
            ChestCardsList.Add(2);
            ChestCardsList.Add(3);
            ChestCardsList.Add(4);
            ChestCardsList.Add(4);
            ChestCardsList.Add(5);
            ChestCardsList.Add(6);
            ChestCardsList.Add(7);
            ChestCardsList.Add(8);
            ChestCardsList.Add(9);
            ChestCardsList.Add(10);
            ChestCardsList.Add(11);
            ChestCardsList.Add(12);
            ChestCardsList.Add(13);
            ChestCardsList.Add(14);
            ChestCardsList.Add(15);
            ChestCardsList.Add(16);
        }

        //server
        public static void Shuffle<T>(IList<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public string ChanceDisplayText(int id) {
            string displaytext = "ERROR";
            switch (id) {
            case 0:
                displaytext = "Advance to GO (Collect $200)";
                break;
            case 1:
                displaytext = "Advance to Illinois Ave";
                break;
            case 2:
                displaytext = "Advance to St. Charles Place";
                break;
            case 3:
                displaytext = "Advance to nearest Utility\nIf unowned, you may buy it from the bank\nIf owned, throw dice and pay owner a total of ten times the amount thrown";
                break;
            /* There are two of these */
            case 4:
                displaytext = "Advance to nearest Railroad\nIf unowned, you may buy it from the bank\n If owned, pay owner twice the rental to which they are otherwise entitled";
                break;
            case 5:
                displaytext = "Your stocks mature\nCollect $50 from the bank";
                break;
            case 6:
                displaytext = "Get out of Jail Free\nThis card may be kept until needed, traded, or sold";
                break;
            case 7:
                displaytext = "Go Back Three Spaces";
                break;
            case 8:
                displaytext = "Go to Jail\nGo directly to Jail\nDo not pass GO, do not collect $200";
                break;
            case 9:
                displaytext = "Make general repairs on all your properties\nFor each house pay $25, For each hotel pay $100";
                break;
            case 10:
                displaytext = "Speeding fine\nPay $15";
                break;
            case 11:
                displaytext = "Take a ride on the Reading Railroad\nAdvance to Reading Railroad";
                break;
            case 12:
                displaytext = "Take a walk on the Boardwalk\nAdvance to Boardwalk";
                break;
            case 13:
                displaytext = "Get Rekt\nPay each player $50";
                break;
            case 14:
                displaytext = "Your building and loan matures\nCollect $150 from the bank";
                break;
            case 15:
                displaytext = "You have won a crossword competition\nCollect $100 from the bank";
                break;
            }

            return displaytext;
        }

        public string ChestDisplayText(int id) {
            string displaytext = "ERROR";
            switch (id) {
            case 0:
                displaytext = "Advance to GO (Collect $200)";
                break;
            case 1:
                displaytext = "Bank error in your favor\nCollect $200 from the bank";
                break;
            case 2:
                displaytext = "Doctor's fees\nPay $50";
                break;
            case 3:
                displaytext = "From sale of stock\nCollect $50 from the bank";
                break;
            case 4:
                displaytext = "Get out of Jail Free\nThis card may be kept until needed, traded, or sold";
                break;
            case 5:
                displaytext = "Go to Jail\nGo directly to Jail\nDo not pass GO, do not collect $200";
                break;
            case 6:
                displaytext = "Grand Opera Night\nCollect $50 from every player";
                break;
            case 7:
                displaytext = "Holiday fund matures\nCollect $100 from the bank";
                break;
            case 8:
                displaytext = "Income tax refund\nCollect $20 from the bank";
                break;
            case 9:
                displaytext = "It's your birthday\nCollect $10 from every player";
                break;
            case 10:
                displaytext = "Life insurance matures\nCollect $100 from the bank";
                break;
            case 11:
                displaytext = "Hospital fees\nPay $50";
                break;
            case 12:
                displaytext = "School fees\nPay $50";
                break;
            case 13:
                displaytext = "Consultancy service fee\nCollect $25 from the bank";
                break;
            case 15:
                displaytext = "You are assessed for street repairs\nFor each house pay $40, For each hotel pay $115";
                break;
            case 16:
                displaytext = "You have won second prize in a beauty contest\nCollect $10 from the bank";
                break;
            case 17:
                displaytext = "Inheritance\nCollect $100 from the bank";
                break;
            }

            return displaytext;
        }
    }
}