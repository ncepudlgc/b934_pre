# HellPlus - Terraria Mod

## Repo简介

HellPlus 是一个为 Terraria 游戏添加新内容的大型模组（mod），基于 tModLoader 框架开发。该模组为游戏添加了丰富的地狱主题内容，包括新的武器、盔甲、物品、方块、敌人和游戏机制。

### 主要功能

- **新武器系统**：添加了多种魔法武器和近战武器，包括：
  - 魔法武器：MasterStaff、GrandeStaff、HellStar、Navy 等
  - 近战武器：ObsidianBroadsword、ObsidianShortsword、DragonglassDagger、Demonjaws 等
  - 远程武器：CM47 等

- **新盔甲套装**：包括 Magmium 系列和 CooledMagmium 系列盔甲，提供完整的头盔、胸甲和护腿

- **新材料系统**：
  - Magmium 系列：MagmiumOre、MagmiumBar、MagmiumBrick 等
  - CooledMagmium 系列：CooledMagmiumOre、CooledMagmiumBar、CooledMagmiumBrick 等
  - 其他材料：Krullkite、Deathfelsen、Pentagram 等

- **新敌人和 NPC**：添加了 DemonDolphin 等新敌人

- **新 Buff 和效果**：包括 Fury、PureHellfire、Randomness 等状态效果

- **世界生成系统**：通过 WorldSystem 和 HellPlusOreGenPass 在地狱区域生成新的矿石

- **音效和视觉效果**：包含丰富的音效资源和粒子效果

### 技术栈

- **开发框架**：tModLoader（Terraria Mod Loader）
- **编程语言**：C#
- **游戏引擎**：Terraria（基于 XNA Framework）
- **构建工具**：.NET Framework / .NET Core

### 项目结构

```
HellPlus/
├── Assets/              # 资源文件（音效等）
│   └── Sounds/
├── Common/              # 通用系统
│   └── Systems/
│       └── GenPasses/   # 世界生成相关
├── Content/            # 游戏内容
│   ├── Buffs/          # 状态效果
│   ├── Dusts/          # 粒子效果
│   ├── Items/          # 物品
│   │   ├── Accessories/ # 饰品
│   │   ├── Armor/      # 盔甲
│   │   ├── Consumables/# 消耗品
│   │   ├── Placeable/  # 可放置物品
│   │   ├── Tools/      # 工具
│   │   └── Weapons/    # 武器
│   ├── NPCs/           # NPC和敌人
│   ├── Projectiles/    # 弹射物
│   ├── Tiles/          # 方块
│   └── Walls/          # 墙壁
├── Localization/       # 本地化文件
├── Properties/         # 项目属性
├── HellPlus.cs         # 主模组类
├── HellPlus.csproj     # 项目文件
└── README.md           # 说明文档
```

## 题目Prompt

Please create a sword called 'Magmaul' with the following features: the texture for it will have a width and height of 40 and it will deal 200 damage, feel free to come up with your own values for the useTime, useAnimation, etc. Also, to craft it you need to be at a mythril anvil with a terra blade and 12 magmium bars.

## PR链接

https://github.com/ncepudlgc/b934_pre/pull/1
