internal class AutoUpBK : ThreadActionUpdate<AutoUpBK>
{
    public override int Interval => 10000; // 10 giây
    protected override void Update()
    {
        Helper.useItem(381, 0);
    }
}
