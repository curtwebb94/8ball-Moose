using System;

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose 8 Ball Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    //run Main!

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    string question;

// the while loop continues indefinitely (while (true))
    while (true)
    {
        Console.WriteLine("Please enter your question (or type 'exit' to quit):");
        question = Console.ReadLine();

        if (question.ToLower() == "exit")
        {
            break;  // Exit the loop
        }
        else
        {
            // Process the user's question
            Console.WriteLine("You asked: " + question);

            // Add more logic here to handle the question as needed

            // To get random Questions
            Random random = new Random();
            string[] responses = {
    "That's an interesting question!",
    "I'm not sure, can you provide more details?",
    "I'll need to look that up. Give me a moment.",
    "I'm sorry, I don't have the answer to that.",
    "Yes, definitely!",
    "No, I don't think so."
};
            //To get random questions and make the Moose Say it
            int randomIndex = random.Next(responses.Length);
            string randomResponse = responses[randomIndex];
            MooseSays(randomResponse);

        //the ending of the else logic
        }
        // the ending of the question string
    }

}

// Call Main to get Program to Work

Main();


void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


