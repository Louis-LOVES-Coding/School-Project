
# **Football Penalty Shootout Game**

## **Description**
The Football Penalty Shootout Game is a fun and interactive desktop game where you try to score penalties against a goalkeeper. The player selects a target in the goal, and the goalkeeper reacts dynamically to block the ball.

---

## **Features**
- 🎯 **Five Target Areas**: Aim for left, right, top, top-left, or top-right goal areas.
- 🧤 **Dynamic Goalkeeper**: A challenging and responsive goalkeeper reacts to your shots.
- 🎵 **Audio Feedback**: Realistic sounds for goals and misses.
- 📊 **Score Tracking**: Keep track of your total goals and misses.
- 👀 **Visual Feedback**: Instant result display for every shot.

---

## **How to Play**
1. **Start the Game**: Launch the game application.
2. **Take a Shot**: Click on one of the five target areas to aim and shoot.
3. **View Results**: Watch if the goalkeeper blocks your shot or if you score a goal.
4. **Play Again**: The game automatically resets for the next attempt.
5. **Compete with Yourself**: Keep improving your score!

---

## **Controls**
- **Mouse**: Click on the goal target areas to aim and shoot.

---

## **System Requirements**
- **Operating System**: Windows  
- **Framework**: .NET Framework  
- **Sound Files**: Ensure `goalSound.wav` and `missSound.wav` are located in the application directory.

---

## **Setup Instructions**
1. Download all game files.
2. Place `goalSound.wav` and `missSound.wav` in the application's directory.
3. Double-click the executable file to start the game.

---

## **Customization**
### Changing Sounds
- Replace `goalSound.wav` and `missSound.wav` with your custom sound files.
- Keep the file names unchanged.

### Adjusting Goalkeeper Difficulty
- Open the source code.
- Modify the `saveChance` variable in the `ChangeGoalKeeperImage()` method to adjust the goalkeeper’s reaction probability:
  ```csharp
  double saveChance = 0.8; // Higher value means harder goalkeeper.
  ```

---

## **Known Issues**
- Missing sound files may cause errors; ensure they are present in the correct location.
- The game window might not scale well on very small resolutions.

---

## **Credits**
**Developer**: [Your Name]  
**Contact**: [Your Email or Website]  
