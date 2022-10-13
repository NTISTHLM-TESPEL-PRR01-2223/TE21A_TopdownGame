using Raylib_cs;

Raylib.InitWindow(1024, 768, "Topdown game");
Raylib.SetTargetFPS(60);

Rectangle character = new Rectangle(0, 60, 50, 50);
float speed = 4.5f;

//                       r   g    b    a
Color myColor = new Color(0, 200, 30, 255);

while (Raylib.WindowShouldClose() == false)
{
  if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
  {
    character.x += speed;
  }

  Raylib.BeginDrawing();

  Raylib.ClearBackground(Color.WHITE);

  Raylib.DrawRectangleRec(character, myColor);

  // Raylib.DrawRectangle(0, 60, 50, 50, myColor);
  // Raylib.DrawRectangle(0, 70, 50, 50, Color.RED);

  Raylib.EndDrawing();
}