using SkiaSharp;

namespace Projeto {
    class Program {
        static void Main(string[] args) {
            using (SKBitmap bitmapEntrada = SKBitmap.Decode("Exercicio 3.png")) {
                unsafe {
                    byte* entrada = (byte*)bitmapEntrada.GetPixels();

                    int largura = bitmapEntrada.Width;
                    int altura = bitmapEntrada.Height;
                    int[] pixels = new int[256];

                    // Contar a quantidade de pixels para cada valor
                    for (int y = 0; y < altura; y++) {
                        for (int x = 0; x < largura; x++) {
                            pixels[entrada[y * largura + x]] += 1;
                        }
                    }

                    // Imprimir a quantidade de pixels para cada valor
                    for (int z = 0; z <= 255; z++) {
                        Console.WriteLine("Quantidade de pixels com valor " + z + ": " + pixels[z]);
                    }
                }
            }
        }
    }
}
