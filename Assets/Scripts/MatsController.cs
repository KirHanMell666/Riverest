using TMPro;
using UnityEngine;

public class MatsController : MonoBehaviour
{
    [SerializeField] int coin;
    [SerializeField] int woodLog;
    [SerializeField] int woodenPlank;
    [SerializeField] int stone;
    [SerializeField] int iron;
    [SerializeField] int gold;
    [SerializeField] int sapphire;
    [SerializeField] int ruby;
    [SerializeField] int diamond;

    [SerializeField] TextMeshProUGUI coinText;
    [SerializeField] TextMeshProUGUI woodLogText;
    [SerializeField] TextMeshProUGUI woodenPlankText;
    [SerializeField] TextMeshProUGUI stoneText;
    [SerializeField] TextMeshProUGUI ironText;
    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] TextMeshProUGUI sapphireText;
    [SerializeField] TextMeshProUGUI rubyText;
    [SerializeField] TextMeshProUGUI diamondText;

    private void Start()
    {
        UpdateAllTexts();
    }

    private void UpdateAllTexts()
    {
        UpdateCoinText();
        UpdateWoodLogText();
        UpdateWoodenPlankText();
        UpdateStoneText();
        UpdateIronText();
        UpdateGoldText();
        UpdateSapphireText();
        UpdateRubyText();
        UpdateDiamondText();
    }

    // coin
    public void AddCoin(int count)
    {
        coin += count;
        UpdateCoinText();
    }

    public void RemoveCoin(int count)
    {
        coin -= count;
        UpdateCoinText();
    }

    public void SetCoin(int count)
    {
        coin = count;
        UpdateCoinText();
    }

    public void UpdateCoinText()
    {
        coinText.text = coin.ToString();
    }

    // wood log
    public void AddWoodLog(int count)
    {
        woodLog += count;
        UpdateWoodLogText();
    }

    public void RemoveWoodLog(int count)
    {
        woodLog -= count;
        UpdateWoodLogText();
    }

    public void SetWoodLog(int count)
    {
        woodLog = count;
        UpdateWoodLogText();
    }

    public void UpdateWoodLogText()
    {
        woodLogText.text = woodLog.ToString();
    }

    // wooden plank
    public void AddWoodenPlank(int count)
    {
        woodenPlank += count;
        UpdateWoodenPlankText();
    }

    public void RemoveWoodenPlank(int count)
    {
        woodenPlank -= count;
        UpdateWoodenPlankText();
    }

    public void SetWoodenPlank(int count)
    {
        woodenPlank = count;
        UpdateWoodenPlankText();
    }

    public void UpdateWoodenPlankText()
    {
        woodenPlankText.text = woodenPlank.ToString();
    }

    // iron
    public void AddIron(int count)
    {
        iron += count;
        UpdateIronText();
    }

    public void RemoveIron(int count)
    {
        iron -= count;
        UpdateIronText();
    }

    public void SetIron(int count)
    {
        iron = count;
        UpdateIronText();
    }

    public void UpdateIronText()
    {
        ironText.text = iron.ToString();
    }

    // gold
    public void AddGold(int count)
    {
        gold += count;
        UpdateGoldText();
    }

    public void RemoveGold(int count)
    {
        gold -= count;
        UpdateGoldText();
    }

    public void SetGold(int count)
    {
        gold = count;
        UpdateGoldText();
    }

    public void UpdateGoldText()
    {
        goldText.text = gold.ToString();
    }

    // stone
    public void AddStone(int count)
    {
        stone += count;
        UpdateStoneText();
    }

    public void RemoveStone(int count)
    {
        stone -= count;
        UpdateStoneText();
    }

    public void SetStone(int count)
    {
        stone = count;
        UpdateStoneText();
    }

    public void UpdateStoneText()
    {
        stoneText.text = stone.ToString();
    }

    // ruby
    public void AddRuby(int count)
    {
        ruby += count;
        UpdateRubyText();
    }

    public void RemoveRuby(int count)
    {
        ruby -= count;
        UpdateRubyText();
    }

    public void SetRuby(int count)
    {
        ruby = count;
        UpdateRubyText();
    }

    public void UpdateRubyText()
    {
        rubyText.text = ruby.ToString();
    }

    // sapphire
    public void AddSapphire(int count)
    {
        sapphire += count;
        UpdateSapphireText();
    }

    public void RemoveSapphire(int count)
    {
        sapphire -= count;
        UpdateSapphireText();
    }

    public void SetSapphire(int count)
    {
        sapphire = count;
        UpdateSapphireText();
    }

    public void UpdateSapphireText()
    {
        sapphireText.text = sapphire.ToString();
    }

    // diamond
    public void AddDiamond(int count)
    {
        diamond += count;
        UpdateDiamondText();
    }

    public void RemoveDiamond(int count)
    {
        diamond -= count;
        UpdateDiamondText();
    }

    public void SetDiamond(int count)
    {
        diamond = count;
        UpdateDiamondText();
    }

    public void UpdateDiamondText()
    {
        diamondText.text = diamond.ToString();
    }
}
