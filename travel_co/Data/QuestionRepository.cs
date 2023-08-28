using System;
namespace travel_co.Data
{
	public class QuestionRepository
	{
        public static List<Question> Questions = new List<Question>
    {
        new Question { QuestionQ = "Jak zjistím veškeré podrobné info o daném zájezdu?", AnswerQ = "Veškeré podrobné info je dostupné v .pdf souboru, který je dostupný po zaplacení první zálohy." },
        new Question { QuestionQ = "Do kdy můžu zrušit svou rezervaci na zájezd?", AnswerQ = "Rezervaci je možné bezplatně zrušit do zaplacení první zálohy, která bývá zpravidla dva měsíce před začátkem zájezdu." },
        new Question { QuestionQ = "Je potřebné si koupit pojištění na zájezd?", AnswerQ = "Ne, není. Pojištění zajišťujeme hromadně pro všechny účastníky zájezdu a je tak součástí ceny zájezdu." },
        new Question { QuestionQ = "Od, popř. do jakého věku je možné s námi cestovat?", AnswerQ = "Věková hranice není určena, avšak každý účastník by měl zvážit, zda-li je jeho zdravotní stav v dostatečně dobrém stavu" +
            ", popř. zda-li je věk dítěte úměrný náročnosti zájezdu."},
        new Question { QuestionQ = "Dle čeho se vyhodnocují reklamace na případné stížnosti nebo potíže, které nastaly během zájezdu?", AnswerQ = "Vše se vyhodnocuje dle reklamačního řádu, viz. konec stránky."}
    };
    }
}

