using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using Workle.Models;

namespace Workle.Service.CardReaders
{
    public class CardReaderJson : ICardReader
    {
        private Cards _cards;
        private string _path;

        public CardReaderJson(string path)
        {           
            _path = path;
            try
            {
                var rawJson = File.ReadAllText(_path);
                _cards = JsonConvert.DeserializeObject<Cards>(rawJson);
            }
            catch (Exception ex)
            {

                System.Console.WriteLine($"Не удалось десериализовать json :{ex.Message}");
            }
        }

        public Card GetCardOrNull(int bin)
        {
            var card = _cards.Card.Where(x => x.Bin == bin).FirstOrDefault();
            return card;
        }
    }
}