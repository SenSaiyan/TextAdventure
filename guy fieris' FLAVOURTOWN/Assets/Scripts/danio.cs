using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class danio : MonoBehaviour
{
    public string currentRoom;
    private string room_up = "";
    private string room_down = "";
    private string room_left = "";
    private string room_right = "";
    private string space = "";
    public string text;
    private int visits = 0;
    private int buttonsPressed = 0;
    private bool hasBananas = false;
    private bool hasAngus = false;
    private bool hasWisdom = false;
    private bool anime = false;
    private bool daddy_issues = false;
    private bool flavorpistols = false;
    private bool cavePuzzle = false;
    private bool room1;
    private bool room3;
    private bool room4;
    private bool room7;
    private bool room0;

    void Start()
    {
        currentRoom = "start";
    }

    void Update()
    {
        room_down = "";
        room_up = "";
        room_left = "";
        room_right = "";

        if (currentRoom == "start")
        {
            text = "Welcome to Guy Feiris' FLAVOURTOWN!!!";
            text += "\n Press spacebar to DIVE INTO this excellent adventure";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                currentRoom = "townhall";
            }
        }

        else if (currentRoom == "townhall")
        {
            room_left = "swamp";
            room_right = "courts";
            if (visits == 0)
            {
                text = "To protect the world from devastation and a lack of meaningful spices, the man, the myth, AND THE LEGEND GUY FIERI HIMSELF must embark on an adventure of epic proportions just like the portions he eats on his Food Network show Diners, Drive-In's, and Dives!!!1\n";
                text += "Here in the town hall of FLAVOURTOWN,, Mayor FIERI must make the msot executive of decisions to bring back FLAVOUR to the people.\n";
            }
            if (hasBananas == false)
            {
                if (visits != 0)
                {
                    text = "";
                }
                text += "You must collect the BALLER BANANAS from the basketball courts!!1\n";
            }
            if (hasAngus == false)
            {
                if (visits != 0)
                {
                    if (hasBananas == true)
                    {
                        text = "";
                    }
                }
                text += "You must collect the AWESOME ANGUS from the northern swamps!!!1\n";
            }
            if (hasAngus == true)
            {
                if (hasBananas == true)
                {
                    text = "ALTHOUGH YOU HAVE ATTAINED these FLAVOURFUL treats,, the townspeople do not know how to make delicious FLAVOUR worth GUY FIERIS' TIME!!!\n";
                    text += "You must also give them the gift of... WISDOM!!! ONLY THE WISEST PEOPLE CAN TRULY ATTAIN TRUE FLAVOUR!!!\n";
                    text += "Go, onwards, to the library of WISDOM to truly BECOME WISE!!!!!";
                    room_up = "library";
                }
            }

        }

        else if (currentRoom == "courts")
        {
            room_left = "townhall";
            if (hasBananas == true)
            {
                text = "WHY ARE YOU HERE THERE IS NOTHING LEFT FOR A MAN OF MAGNIFICANT FLAVOUR SUCH AS YOURSELF, GUY FEIRI!!!!";
            }
            else
            {
                text = "The baller BANANAS have since been lost to time due to truly primal beings that have since disgraced the game of basketball, the ones called THE GOLDEN STATE WARRIORS!!\n";
                text += "In order TO DEFEAT THEM, yOU Must INFLICT GR8 pain on them!\n";
                if (anime == false)
                {
                    text += "Press A to use ANIME!\n";
                    text += "Press T to trigger them! EMOTIONALLY!\n";
                    text += "Press F to go on the offensive with your patented FLAVOUR PISTOLS!!";
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        currentRoom = "courtsAnime";
                    }
                    else if (Input.GetKeyDown(KeyCode.T))
                    {
                        currentRoom = "courtsTriggered";
                    }
                    else if (Input.GetKeyDown(KeyCode.F))
                    {
                        currentRoom = "courtsPistols";
                    }
                }

            }
        }

        else if (currentRoom == "courtsAnime")
        {
            room_left = "townhall";
            text = "succes! you inflict gr8 pain because ANIME and AGONY are both five-letter words that start with A!";
            text += "press left to return to the TOWN HALL OF FLAVOUR TOWN";
            hasBananas = true;
            anime = true;
        }

        else if (currentRoom == "courtsTriggered")
        {
            room_left = "townhall";
            text = "FailFish!!! You can't trigger someone who is THAT rich!";
            text += "\n Run away for now by pressing left. You'll get them next time, champ!";
        }

        else if (currentRoom == "courtsPistols")
        {
            room_left = "townhall";
            text = "FailFish!!! Even the FLAVOUR pistols are no match for the agility of the team, who is strengthened from the energy lent by bandwagoning fans!";
            text += "\n Run away for now by pressing left. You'll get them next time, champ!";
        }

        else if (currentRoom == "swamp")
        {
            if (hasAngus == true)
            {
                text = "";
            }
            else
            {
                room_left = "cave";
                room_right = "townhall";
                text = "You find the charred ruined of an ogre hut. Scorched bodies litter the earth, but the only thing on your mind is the priceless artifact you have come to this forsaken land for: the Awesome Angus. While rummaging through the bodies for clues, however, you discover that in the aforementioned mystical item is nowhere to be found.";
                text += "\n Suddenly, you strike upon a glimmer of hope. Upon searching the ogre's meat shack, you find a clue written on a thin sheet of paper used to wrap meat: \n";
                text += "\"From here I was sent to a cage of steel\n";
                text += "From here I will hear no appeal\n";
                text += "In these two rooms, you will what you seek and more\n";
                text += "The greatest number you can score.\"\n";
                text += "Further into the swamps are mysterious caves where strange noises would come out of. Press left to continue.";
            }
        }

        else if (currentRoom == "cave")
        {
            room_right = "swamp";
            if (buttonsPressed == 2)
            {
                currentRoom = "caveButtons";
            }
            else if (cavePuzzle == true)
                {
                    hasAngus = true;
                    text = "congrations you done it!!! You have acquired the AWESOME ANGUS!!! If you have both artifacts, return to the townhall!";
                }
            else
            {
                text = "inside the cave, GUY FIERI comes face to face to a multitude of doors. Peeking inside each one, he notices there are levers in each one.";
                text += "\n above every entrance is a number. There are 5 numbers in total: 1, 3, 4, 7, and 0.";
                text += "\n Enter which door? Press on keyboard.";
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    currentRoom = "room1";
                }
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    currentRoom = "room3";
                }
                if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    currentRoom = "room4";
                }
                if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    currentRoom = "room7";
                }
                if (Input.GetKeyDown(KeyCode.Alpha0))
                {
                    currentRoom = "room0";
                }             
            }
        }

        else if (currentRoom == "caveButtons")
        {
            if (room4 == true && room7 == true)
            {
                cavePuzzle = true;
                text = "Nice!!!!! When you add those two numbers up you get the highest sum! Press space to continue!";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentRoom = "cave";
                }
            }
            else
            {
                text = "What's wrong with you??????????? How did you think that was correct?????? Press space to try again.";
                room0 = false;
                room1 = false;
                room3 = false;
                room4 = false;
                room7 = false;
                buttonsPressed = 0;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentRoom = "cave";
                }
            }
        }

        else if (currentRoom == "room1")
        {
            text = "Room 1 \nPress button? (Y/N?)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                room1 = true;
                buttonsPressed++;
                currentRoom = "cave";
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                currentRoom = "cave";
            }
        }

        else if (currentRoom == "room3")
        {
            text = "Room 3 \n Press button? (Y/N?)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                room3 = true;
                buttonsPressed++;
                currentRoom = "cave";
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                currentRoom = "cave";
            }
        }

        else if (currentRoom == "room0")
        {
            text = "Room 0 \n Press button? (Y/N?)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                room0 = true;
                buttonsPressed++;
                currentRoom = "cave";
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                currentRoom = "cave";
            }
        }

        else if (currentRoom == "room4")
        {
            text = "Room 4 \n Press button? (Y/N?)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                room4 = true;
                buttonsPressed++;
                currentRoom = "cave";
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                currentRoom = "cave";
            }
        }

        else if (currentRoom == "room7")
        {
            text = "Room 7 \n Press button? (Y/N?)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                room7 = true;
                buttonsPressed++;
                currentRoom = "cave";
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                currentRoom = "cave";
            }
        }

        else if (currentRoom == "library")
        {
            text = "Now that the path has been laid before you, GUY FIERI, you must fullfill your destiny by making FLAVOURTOWN GREAT AGAIN! Do you have WHAT IT TAKES TO DIVE INTO THE FLAVOUR?????? (YOU'RE SUPPOSED TO HIT THE Y KEY HERE)";
            if (Input.GetKeyDown(KeyCode.Y))
            {
                text = "Do you believe THAT YOU ARE WORTHY OF BRINGING FLAVOUR BACK???? (Please PRESS Y OMGGGG)";
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    text = "Good because I'm so done with writing this game like wtf it's way too late for this";
                    text += "\n THE END";
                }
            }
        }

        text += "\n\n";

        if (room_up != "")
        {
            text += "Press Up to go to the " + room_up + "\n";
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                currentRoom = room_up;
                visits++;
            }
        }
        if (room_down != "")
        {
            text += "Press Down to go to the " + room_down + "\n";
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                currentRoom = room_down;
                visits++;
            }
        }
        if (room_left != "")
        {
            text += "Press Left to go to the " + room_left + "\n";

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                currentRoom = room_left;
                visits++;
            }
        }
        if (room_right != "")
        {
            text += "Press Right to go to the " + room_right + "\n";
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                currentRoom = room_right;
                visits++;
            }
        }
        GetComponent<Text>().text = text;
    }
}