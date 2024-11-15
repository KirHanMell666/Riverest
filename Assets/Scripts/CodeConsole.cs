using TMPro;
using UnityEngine;

public class CodeConsole : MonoBehaviour
{
    [SerializeField] GameObject consoleObj;
    [SerializeField] TMP_InputField consoleField;
    private bool isConsoleActive;

    private void Start()
    {
        isConsoleActive = false;
        consoleObj.SetActive(isConsoleActive);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
        {
            OnToggleConsole();
        }
    }

    public void OnToggleConsole()
    {
        isConsoleActive = !isConsoleActive;
        consoleObj.SetActive(isConsoleActive);

        if (isConsoleActive)
        {
            consoleField.ActivateInputField();
        }
    }

    public void UseCommand()
    {
        string[] command = consoleField.text.Split();
        if (command.Length > 0)
        {
            GameController gc = GameController.instance;
            switch (command[0])
            {
                // add
                case "add":
                    if (command.Length > 1)
                    {
                        int count = 1;
                        if (command.Length > 2)
                        {
                            int.TryParse(command[2], out count);
                        }
                            switch (command[1])
                        {
                            case "coin":
                                gc.matsController.AddCoin(count);
                                break;
                            case "wood_log":
                                gc.matsController.AddWoodLog(count);
                                break;
                            case "wooden_plank":
                                gc.matsController.AddWoodenPlank(count);
                                break;
                            case "stone":
                                gc.matsController.AddStone(count);
                                break;
                            case "iron":
                                gc.matsController.AddIron(count);
                                break;
                            case "gold":
                                gc.matsController.AddGold(count);
                                break;
                            case "ruby":
                                gc.matsController.AddRuby(count);
                                break;
                            case "sapphire":
                                gc.matsController.AddSapphire(count);
                                break;
                            case "diamond":
                                gc.matsController.AddDiamond(count);
                                break;
                        }
                    }
                    break;
                // set
                case "set":
                    if (command.Length > 1)
                    {
                        int count = 1;
                        if (command.Length > 2)
                        {
                            int.TryParse(command[2], out count);
                        }
                        switch (command[1])
                        {
                            case "coin":
                                gc.matsController.SetCoin(count);
                                break;
                            case "wood_log":
                                gc.matsController.SetWoodLog(count);
                                break;
                            case "wooden_plank":
                                gc.matsController.SetWoodenPlank(count);
                                break;
                            case "stone":
                                gc.matsController.SetStone(count);
                                break;
                            case "iron":
                                gc.matsController.SetIron(count);
                                break;
                            case "gold":
                                gc.matsController.SetGold(count);
                                break;
                            case "ruby":
                                gc.matsController.SetRuby(count);
                                break;
                            case "sapphire":
                                gc.matsController.SetSapphire(count);
                                break;
                            case "diamond":
                                gc.matsController.SetDiamond(count);
                                break;
                        }
                    }
                    break;
                // remove
                case "remove":
                    if (command.Length > 1)
                    {
                        int count = 1;
                        if (command.Length > 2)
                        {
                            int.TryParse(command[2], out count);
                        }
                        switch (command[1])
                        {
                            case "coin":
                                gc.matsController.RemoveCoin(count);
                                break;
                            case "wood_log":
                                gc.matsController.RemoveWoodLog(count);
                                break;
                            case "wooden_plank":
                                gc.matsController.RemoveWoodenPlank(count);
                                break;
                            case "stone":
                                gc.matsController.RemoveStone(count);
                                break;
                            case "iron":
                                gc.matsController.RemoveIron(count);
                                break;
                            case "gold":
                                gc.matsController.RemoveGold(count);
                                break;
                            case "ruby":
                                gc.matsController.RemoveRuby(count);
                                break;
                            case "sapphire":
                                gc.matsController.RemoveSapphire(count);
                                break;
                            case "diamond":
                                gc.matsController.RemoveDiamond(count);
                                break;
                        }
                    }
                    break;
                // help
                case "help":
                    // help stuff TODO
                    break;
            }
        }
        consoleField.text = "";
        consoleField.ActivateInputField();
    }
}
