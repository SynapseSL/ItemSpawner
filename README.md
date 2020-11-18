# ItemSpawner
A small Plugin for Scp:SL that allows to setup new spawn points for items (even for a custom item)

## Config
In order to get a position for an spawn point you can use the command `mappoint` in the game and it gives you the position you are currently looking at

The default config will spawn a O5 in the containment Room for Scp-079
```
[ItemSpawner]
{
# The Items which should spawn each Round
spawns:
- position:
    room: HCZ_079
    x: 5.29060411
    y: -3
    z: -6.44455004
  item:
    iD: 11
    durabillity: 0
    sight: 0
    barrel: 0
    other: 0
    xSize: 1
    ySize: 1
    zSize: 1
  spawnChance: 100
}
```

A Config example you can use if you have installed the [MoreWeapons](https://github.com/SynapseSL/MoreWeapons) plugin
```
[ItemSpawner]
{
# The Items which should spawn each Round
spawns:
- position:
    room: HCZ_457
    x: -1.80886805
    y: 1.33001697
    z: -1.07815599
  item:
    iD: 36
    durabillity: 1
    sight: 0
    barrel: 0
    other: 0
    xSize: 1
    ySize: 1
    zSize: 1
  spawnChance: 100
- position:
    room: HCZ_106
    x: 32.9909058
    y: -12.4075298
    z: -7.12724686
  item:
    iD: 37
    durabillity: 10
    sight: 0
    barrel: 0
    other: 0
    xSize: 1
    ySize: 1
    zSize: 1
  spawnChance: 100
- position:
    room: HCZ_049
    x: 8.38026428
    y: 265.399994
    z: 6.57559204
  item:
    iD: 38
    durabillity: 8
    sight: 0
    barrel: 0
    other: 0
    xSize: 1
    ySize: 1
    zSize: 1
  spawnChance: 100
- position:
    room: EZ_Shelter
    x: 2.58760095
    y: 2.23846412
    z: 7.119596
  item:
    iD: 39
    durabillity: 1
    sight: 3
    barrel: 4
    other: 4
    xSize: 1
    ySize: 1
    zSize: 1.5
  spawnChance: 100
- position:
    room: HCZ_079
    x: 5.29060411
    y: -3
    z: -6.44455004
  item:
    iD: 40
    durabillity: 0
    sight: 0
    barrel: 0
    other: 0
    xSize: 1
    ySize: 1
    zSize: 1
  spawnChance: 100
- position:
    room: LCZ_012 (12)
    x: -4.12225294
    y: -6.5
    z: -0.589004517
  item:
    iD: 41
    durabillity: 0
    sight: 0
    barrel: 0
    other: 0
    xSize: 2
    ySize: 2
    zSize: 2
  spawnChance: 100
}
```
