using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text text;
    private enum States { cell, mirror, sheet_0, lock_0, cell_mirror, sheets_1, lock_1, freedom ,
    corridor_0, corridor_1, corridor_2, corridor_3,stairs_0, stairs_1, stairs_2, floor, closet_door, in_closet, courtyard};
    private States myState;

    // Use this for initialization
    void Start()
    {
        myState = States.cell;
    }

    // Update is called once per frame
    void Update()
    {

        print(myState);

        switch (myState)
        {
            case States.cell:
                state_cell();
                break;
            case States.sheet_0:
                state_sheet_0();
                break;
            case States.cell_mirror:
                state_cell_mirror();
                break;
            case States.freedom:
                state_freedom();
                break;
            case States.lock_0:
                state_lock_0();
                break;
            case States.lock_1:
                state_lock_1();
                break;
            case States.mirror:
                state_mirror();
                break;
            case States.sheets_1:
                state_sheets_1();
                break;
            case States.floor:
                state_floor();
                break;
            case States.closet_door:
                state_closet_door();
                break;
            case States.corridor_0:
                state_corridor_0();
                break;
            case States.corridor_1:
                state_corridor_1();
                break;
            case States.corridor_2:
                state_corridor_2();
                break;
            case States.corridor_3:
                state_corridor_3();
                break;
            case States.courtyard:
                state_courtyard();
                break;
            case States.stairs_0:
                state_stairs_0();
                break;
            case States.stairs_1:
                state_stairs_1();
                break;
            case States.stairs_2:
                state_stairs_2();
                break;
            case States.in_closet:
                state_in_closet();
                break;
        }
    }

    void state_cell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to View Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheet_0;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void state_sheet_0()
    {
        text.text = "You can't believe you sleep in these things. Surely it's "
            + "time somebody changed them. The pleasures of prison life "
            + "I guess!\n\n" +
            "Press R to Return to roaming you cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_mirror()
    {
        text.text = "Wow, you find a mirror now. What can it help you to find out the escape way?\n\n" +
            "Press T to take the Mirror, press R to return cell.";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_lock_0()
    {
        text.text = "Sad, the cell is locked.\n\n" +
            "Press R to return my sweet cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_sheets_1()
    {
        text.text = "The world is splendid, and the sunshine is so warm, but how can I find out my way?\n\n" +
        "Press R to return cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_cell_mirror()
    {
        text.text = "The lock is still there. How can I use mirror? Knock my head. Oh, there is another sheet on the wall.\n\n" +
                    "Press S to view sheets, press L to check Lock.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }

    void state_lock_1()
    {
        text.text = "Oh, the mirror can unlock the lock.\n\n" +
                    "Press O to open lock, press R to return cell.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.corridor_0;
        }
    }

    void state_corridor_0()
    {
        text.text = "Now you are in the dark corridor.You can see the floor, stairs before, and there is a closet in corridro.\n\n" +
            "Press S to up stairs, press F to check floor, press C to open closet.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }

    void state_corridor_1() {
        text.text = "You are in corridro with a hairclip in hand.\n\n" +
    "Press S to up stairs, press P to step in closet..";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.in_closet;
        }
    }
    void state_corridor_2()
    {
        text.text = "You are out of closet and in corridor now.\n\n" +
                    "Press B to back into closet, press S to up stairs.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_2;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.in_closet;
        }
    }
    void state_corridor_3()
    {
        text.text = "You are out of closet and in corridor now.\n\n" +
            "Press U to back into closet and undress, press S to up stairs.";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.courtyard;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myState = States.in_closet;
        }

    }
    void state_stairs_0()
    {
        text.text = "Nothing on the stairs.\n\n" +
            "Press R to return to corridror.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void state_stairs_1()
    {
        text.text = "Nothing on the stairs.\n\n" +
        "Press R to return to corridror.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }
    void state_stairs_2()
    {
        text.text = "Nothing on the stairs.\n\n" +
        "Press R to return to corridror.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
    void state_floor()
    {
        text.text = "You checked floor and found a hairclip.\n\n" +
            "Press H to collect hairclip, press R to return to corridror.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;

        }
    }
    void state_closet_door()
    {
        text.text = "You are in the closet.\n\n" +
                    "Press R to return to corridror.";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void state_in_closet()
    {
        text.text = "You are in closet now.\n\n" +
            "Press D to dress the hairclip as a cleaner to step out, Press R to corridor directly without dressing.";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_2;
        }
    }
    void state_courtyard()
    {
        text.text = "Yeah, I’m free, in courtyad now!!!\n\n" +
                    "Press P to play again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }

    void state_freedom()
    {
        text.text = "Yeah, I’m free!!!\n\n"+
            "Press P to play again.";

        if(Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }
}
