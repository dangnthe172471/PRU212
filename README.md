# Zombie Survival Game - Unity 2D Top-Down Shooter

## 🎮 Mô tả dự án

Zombie Survival Game là một game hành động 2D top-down shooter được phát triển bằng Unity. Người chơi sẽ điều khiển một nhân vật trong thế giới zombie, chiến đấu với các loại kẻ địch khác nhau, nâng cấp khả năng và sinh tồn càng lâu càng tốt.

### 🎯 Thể loại game
- **Top-down Shooter**: Bắn súng góc nhìn từ trên xuống
- **Survival**: Sinh tồn và chiến đấu với zombie
- **RPG Elements**: Nâng cấp nhân vật và vũ khí
- **Procedural Elements**: Hệ thống tăng độ khó theo thời gian

## 🛠️ Công nghệ sử dụng

### Game Engine
- **Unity 2022.3 LTS**
- **C# Scripting**
- **2D Graphics & Animation**

### Core Systems
- **Rigidbody2D Physics**: Hệ thống vật lý 2D
- **Animator**: Hệ thống animation
- **Audio System**: Quản lý âm thanh
- **UI System**: Giao diện người dùng
- **Save System**: Lưu/tải dữ liệu game

### Third-party Assets
- **A* Pathfinding Project**: AI pathfinding cho enemy
- **TextMesh Pro**: Text rendering
- **Unity UI**: User interface components

## 🎮 Tính năng chính

### 👤 Player System
- **Movement**: Di chuyển bằng WASD/Arrow keys
- **Combat**: Bắn súng bằng chuột trái
- **Health System**: Thanh máu và hồi phục
- **Upgrade System**: Nâng cấp tấn công, tốc độ, máu
- **Ammo Management**: Quản lý đạn và reload

### 🧟 Enemy System
- **Multiple Enemy Types**:
  - **BasicEnemy**: Zombie cơ bản
  - **HealEnemy**: Zombie có khả năng hồi máu
  - **EnergyEnemy**: Zombie năng lượng
  - **ExplosionEnemy**: Zombie nổ
  - **MiniEnemy**: Zombie nhỏ
  - **BossEnemy**: Boss mạnh mẽ
- **AI Behavior**: Tự động tìm và tấn công player
- **Health Bars**: Hiển thị máu của enemy
- **Scaling Difficulty**: Tăng độ khó theo thời gian

### 🔫 Weapon System
- **Multi-level Shooting**: Bắn nhiều đạn cùng lúc
- **Ammo Management**: Hệ thống đạn và reload
- **Power-ups**: Tăng cường sức mạnh tạm thời
- **Weapon Upgrades**: Nâng cấp vũ khí

### 🎯 Game Mechanics
- **Energy System**: Thu thập năng lượng để gọi boss
- **Gold System**: Tiền tệ để nâng cấp
- **Scoring**: Hệ thống điểm số
- **Progressive Difficulty**: Tăng độ khó theo thời gian
- **Power-up Timer**: Thời gian tăng cường sức mạnh

## 📁 Cấu trúc dự án

```
PRU212/
├── Project/                    # Unity Project
│   ├── Assets/
│   │   ├── Scripts/           # C# Scripts
│   │   │   ├── Player.cs      # Player controller
│   │   │   ├── Enemy.cs       # Base enemy class
│   │   │   ├── Gun.cs         # Weapon system
│   │   │   ├── GameManager.cs # Game state management
│   │   │   └── ...            # Other scripts
│   │   ├── Scenes/            # Game scenes
│   │   │   ├── SampleScene.unity
│   │   │   ├── Man_1.unity
│   │   │   ├── Man_2.unity
│   │   │   ├── Man_3.unity
│   │   │   └── Man_4.unity
│   │   ├── Prefabs/           # Game objects
│   │   │   ├── enemies/       # Enemy prefabs
│   │   │   ├── PlayerBullet.prefab
│   │   │   ├── EnemyBullet.prefab
│   │   │   └── ...
│   │   ├── Sprites/           # 2D Graphics
│   │   ├── Audio/             # Sound effects & music
│   │   ├── Animations/        # Animation clips
│   │   └── UI/                # User interface
│   └── ProjectSettings/       # Unity settings
├── Sprites/                   # External sprite assets
│   ├── Boss/
│   ├── Guns/
│   ├── Item/
│   ├── NV/
│   └── Zomblie/
└── README.md
```

## 🎮 Gameplay

### 🎯 Mục tiêu
- Sinh tồn càng lâu càng tốt
- Thu thập năng lượng để gọi boss
- Tiêu diệt zombie và kiếm điểm
- Nâng cấp nhân vật để mạnh hơn

### 🎮 Điều khiển
- **WASD/Arrow Keys**: Di chuyển nhân vật
- **Mouse Left Click**: Bắn súng
- **R**: Reload vũ khí
- **ESC**: Pause game
- **Mouse Movement**: Nhắm mục tiêu

### 🏆 Hệ thống điểm
- Tiêu diệt enemy: +100 điểm
- Boss: +1000 điểm
- Điểm được lưu và hiển thị trên UI

## 🗄️ Data Management

### 📊 Game Data (gameData.json)
```json
{
    "gold": 9446,
    "attack": 35.0,
    "moveSpeed": 5.45,
    "maxHp": 130.0
}
```

### 👤 Player Data (playerData.json)
```json
{
    "x": 9.57,
    "y": 2.55,
    "z": 0.0,
    "currentHp": 76.0
}
```

### 🧟 Enemy Data (enemyData.json)
```json
{
    "enemies": [
        {
            "enemyType": "BasicEnemy",
            "x": 0.79,
            "y": -1.93,
            "z": 0.0,
            "currentHpEnemy": 24.0
        }
    ]
}
```

## 🎨 Visual & Audio

### 🎨 Graphics
- **2D Sprites**: Pixel art style
- **Animations**: Character movement và combat
- **Particle Effects**: Blood, explosion, fire effects
- **UI Design**: Modern game interface

### 🔊 Audio
- **Background Music**: Ambient và combat music
- **Sound Effects**: Gunshots, explosions, enemy sounds
- **Audio Manager**: Centralized audio control

## 🔧 Technical Features

### 🎮 Game Systems
- **State Management**: Menu, gameplay, pause states
- **Save/Load System**: Persistent game data
- **Object Pooling**: Efficient bullet management
- **Collision Detection**: Player-enemy interactions

### 🧠 AI Systems
- **Pathfinding**: A* algorithm for enemy movement
- **Behavior Trees**: Enemy AI patterns
- **Targeting**: Enemy targeting player
- **Spawn System**: Dynamic enemy spawning

### 📱 UI/UX
- **Health Bars**: Player và enemy health display
- **Ammo Counter**: Current ammo display
- **Score Display**: Real-time score tracking
- **Menu System**: Main menu, pause, game over

## 🚀 Cài đặt và chạy

### Yêu cầu hệ thống
- **Unity 2022.3 LTS** hoặc mới hơn
- **Windows 10/11** hoặc **macOS**
- **RAM**: 8GB minimum
- **Graphics**: DirectX 11 compatible

### Bước 1: Clone repository
```bash
git clone <repository-url>
cd PRU212
```

### Bước 2: Mở Unity
1. Mở Unity Hub
2. Click "Open" → "Add project from disk"
3. Chọn thư mục `Project`
4. Đợi Unity import project

### Bước 3: Chạy game
1. Mở scene `SampleScene` trong `Assets/Scenes/`
2. Click Play button trong Unity Editor
3. Hoặc build game để chạy standalone

### Bước 4: Build Game
1. File → Build Settings
2. Chọn platform (Windows, macOS, etc.)
3. Click "Build" hoặc "Build and Run"

## 🎯 Game Levels

### 📍 Scenes
- **SampleScene**: Scene chính để test
- **Man_1**: Level 1
- **Man_2**: Level 2  
- **Man_3**: Level 3
- **Man_4**: Level 4

### 🎮 Level Progression
- Mỗi level có độ khó tăng dần
- Enemy spawn rate tăng theo thời gian
- Boss xuất hiện khi đủ năng lượng
- Power-ups xuất hiện định kỳ

## 🔧 Development

### 📝 Scripts Overview
- **Player.cs**: Player movement và combat
- **Enemy.cs**: Base enemy class với AI
- **Gun.cs**: Weapon system và shooting
- **GameManager.cs**: Game state và UI management
- **AudioManager.cs**: Sound management

### 🎨 Asset Organization
- **Prefabs**: Reusable game objects
- **Scripts**: C# code files
- **Sprites**: 2D graphics
- **Audio**: Sound files
- **Scenes**: Game levels

## 🐛 Known Issues & Future Improvements

### 🔧 Potential Improvements
- **Multiplayer Support**: Co-op gameplay
- **More Enemy Types**: Variety in enemies
- **Weapon Variety**: Different weapon types
- **Level Design**: More complex maps
- **Story Mode**: Campaign progression

### 🎯 Performance Optimizations
- **Object Pooling**: Better memory management
- **LOD System**: Level of detail
- **Culling**: Frustum culling for off-screen objects
- **Audio Optimization**: Audio compression

## 📝 License

Dự án được phát triển cho mục đích học tập và nghiên cứu.

## 🤝 Đóng góp

1. Fork dự án
2. Tạo feature branch (`git checkout -b feature/NewFeature`)
3. Commit changes (`git commit -m 'Add new feature'`)
4. Push to branch (`git push origin feature/NewFeature`)
5. Tạo Pull Request

## 📞 Liên hệ

- **Email**: developer@zombiesurvival.com
- **Project Link**: [https://github.com/your-username/PRU212](https://github.com/your-username/PRU212)

---

🎮 **Chúc bạn chơi game vui vẻ và sinh tồn thành công!** 🧟‍♂️ 