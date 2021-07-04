public interface ITabuleiro{
    int CamposVazios { get; }
    void ExecutarJogada (int x, int y, char simbolo);

    bool IsCampoVazio (int x, int y);
}