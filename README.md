# Jumping Madness

A fun platformer game built with Unity where players test their reflexes by jumping over obstacles and collecting items.

## Play Online

Visit [https://Corbank.github.io/JumpingMadness] to play the game directly in your browser.

## Game Features

- Fast-paced platformer gameplay
- Challenging obstacles and enemies
- Collectible items and power-ups
- Progressive difficulty levels
- Responsive controls for both desktop and mobile devices

## How to Play

- **Desktop:** Use arrow keys or WASD to move, Space to jump
- **Mobile:** Touch left/right sides of the screen to move, tap center to jump

## Development Setup

### Prerequisites

- Unity 2022.3 or newer
- WebGL build support module installed in Unity

### Running Locally

1. Clone the repository:
   ```
   git clone https://github.com/Corbank/JumpingMadness.git
   ```

2. Open the project in Unity:
   - Launch Unity Hub
   - Click "Add" and select the JumpingMadness folder
   - Open the project

3. To play in the editor:
   - Open the main scene (Assets/Scenes/MainScene.unity)
   - Press the Play button

## Hosting the Game

### GitHub Pages

1. Make sure your WebGL build is in a folder named "WebGLBuild" in the repository root
2. Push your changes to GitHub
3. Go to your repository settings, select "Pages"
4. Set the source to "main" branch and save
5. Your game will be available at https://Corbank.github.io/JumpingMadness

### Local Testing

For testing locally, you need to serve the files using a web server:

```bash
# Using Python 3
python -m http.server
```

Then visit `http://localhost:8000` in your browser.

## Further Development Tips

### Unity WebGL Settings

To ensure the best web experience:

1. In Unity, go to Edit > Project Settings > Player
2. Under WebGL settings tab:
   - Set "Compression Format" to Gzip
   - Enable "Data Caching"
   - Set appropriate "Memory Size"
   - Consider lowering texture quality for better performance

### Optimizing for Web

1. Reduce texture sizes and polygon counts
2. Minimize scene loading times by optimizing assets
3. Test on multiple browsers (Chrome, Firefox, Safari)
4. Add loading progress indicators using Unity's built-in APIs

## Troubleshooting

If the game doesn't load:

1. Check if your browser supports WebGL (try Chrome or Firefox)
2. Make sure you're using a web server, not opening files directly (file:// protocol)
3. Verify the build files are in the correct location (WebGLBuild/ or Build/ folder)
4. Check browser console for specific errors
5. Try clearing your browser cache

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Credits

- Game Design & Development: [Corban Kass, Claude Anthropic Sonnet 3.7]
- Art Assets: [Anthropic, C.Kass]
- Special Thanks: [Github Copilot]

## Contact

For questions or feedback, please contact [Corbankass@tinyguystudios.com].
