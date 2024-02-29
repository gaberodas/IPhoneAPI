
namespace IPhoneApi.Controllers
{
	public static class Messages
	{
		public static List<Message> ToList()
		{
			var messages = new List<Message>
			{
				new Message{
					Id=1,
					Text="",
					ImageName = "IPhoneApi.Images.grinch.jpg"
                },
				new Message
				{
					Id=2,
					Text = "A healthy outside starts from the inside.",
					ImageName="IPhoneApi.Images.italy.jpg"
                },
                                new Message
                {
                    Id=3,
                    Text = "Success is not final, failure is not fatal: It is the courage to continue that counts.",
                    ImageName="IPhoneApi.Images.river.jpeg"
                }
            };

			return messages;
		}

	}

	public class Message
	{
		public int Id { get; set; }
		public string Text { get; set; }
		public string ImageName { get; set; }
	}
}

