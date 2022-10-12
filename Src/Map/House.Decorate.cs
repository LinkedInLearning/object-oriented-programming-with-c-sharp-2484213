namespace OOPAdventure;

public partial class House
{

    public void DecorateRooms()
    {

        foreach(var room in Rooms)
        {

            var roomDescription = Text.Language.RoomDescriptions[0];

            if(Text.Language.RoomDescriptions.Count > 1 && _rnd.Next(0,2) == 1)
            {
                roomDescription = Text.Language.RoomDescriptions[_rnd.Next(1, Text.Language.RoomDescriptions.Count)];

                Text.Language.RoomDescriptions.Remove(roomDescription);
            }

            room.Description = String.Format(Text.Language.DefaultRoomDescription, roomDescription, "{0}");

        }

    }

    public void PopulateRooms(List<Item> items)
    {

        var i = 0;

        while(i != items.Count)
        {

            var room = Rooms[_rnd.Next(0, Rooms.Length)];

            if(room.Total == 0)
            {

                room.Add(items[i]);

                i++;

            }

        }

    }

}
