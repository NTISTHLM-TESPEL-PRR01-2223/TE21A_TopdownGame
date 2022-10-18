using Raylib_cs;

Raylib.InitWindow(1024, 768, "Topdown game");
Raylib.SetTargetFPS(60);

Rectangle character = new Rectangle(0, 60, 50, 50);
float speed = 4.5f;

Texture2D avatarImage = Raylib.LoadTexture("avatar.png");

//                        r   g    b   a
Color myColor = new Color(0, 200, 30, 255);

string currentScene = "start"; // start, game, win, gameover

while (Raylib.WindowShouldClose() == false)
{
  // LOGIK

  if (currentScene == "game")
  {
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
      character.x += speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
      character.x -= speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
      character.y += speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
      character.y -= speed;
    }
  }
  else if (currentScene == "start")
  {
    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
    {
      currentScene = "game";
    }
  }

  // GRAFIK

  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  if (currentScene == "game")
  {
    Raylib.DrawTexture(avatarImage,
            (int)character.x,
            (int)character.y,
            Color.WHITE
          );
  }
  else if (currentScene == "start")
  {
    Raylib.DrawText("Press ENTER to start", 315, 500, 32, myColor);
  }

  Raylib.EndDrawing();
}