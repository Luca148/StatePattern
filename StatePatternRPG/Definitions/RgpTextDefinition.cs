namespace StatePatternRPG.Definitions;

public class RpgText
{
    public Rooms rooms { get; } = new();
}

public class Rooms
{
    public Empty empty { get; } = new();
    public Enemy enemy { get; } = new();
    public Trap trap { get; } = new();
    public DeadEnd dead_end { get; } = new();
}

public class Empty
{
    public List<string> descriptions { get; } =
    [
        "The room is quiet and empty. Dust covers the floor, and the faint sound of dripping water echoes through the walls.",
        "You enter a deserted chamber. There is nothing immediately threatening, but the silence makes you uneasy.",
        "The room appears to have been abandoned long ago. Broken stones and old footprints are scattered across the floor."
    ];

    public EmptyInteractions interactions { get; } = new();
}

public class EmptyInteractions
{
    public List<string> proceed { get; } =
    [
        "You move deeper into the dungeon.",
        "You carefully continue through the room.",
        "You decide not to linger and head onward."
    ];

    public List<string> observe { get; } =
    [
        "You search the room carefully, but find nothing of value.",
        "You inspect the walls and floor. Nothing seems out of place.",
        "After a closer look, you discover only dust, rubble, and old footprints."
    ];

    public List<string> interact { get; } =
    [
        "You touch the old stone wall. Nothing happens.",
        "You investigate a loose stone, but there is nothing behind it.",
        "You search the room for anything useful, but come up empty-handed."
    ];

    public List<string> attack { get; } =
    [
        "You swing your weapon through the empty air. There is nothing here to fight.",
        "You prepare to attack, but quickly realize there is no enemy.",
        "You raise your weapon cautiously. The room remains completely still."
    ];
}

public class Enemy
{
    public List<string> descriptions { get; } =
    [
        "A hostile creature emerges from the shadows. Its eyes lock onto you, and it prepares to attack.",
        "You hear a low growl from the darkness. A dangerous enemy steps into the light and blocks your path.",
        "Before you can move, a creature leaps from behind a pile of rubble. It looks ready for a fight."
    ];

    public EnemyInteractions interactions { get; } = new();
}

public class EnemyInteractions
{
    public List<string> proceed { get; } =
    [
        "You try to move past the enemy, but it refuses to let you pass.",
        "The enemy blocks your path. You cannot proceed without dealing with it.",
        "You take a step forward, but the creature stands firmly in your way."
    ];

    public List<string> observe { get; } =
    [
        "You study your opponent carefully. It looks strong, but not invincible.",
        "You watch the creature's movements and search for a weakness.",
        "You keep your distance and analyze the enemy before making your next move."
    ];

    public List<string> interact { get; } =
    [
        "You attempt to communicate with the creature. It responds with an angry growl.",
        "You cautiously approach the enemy, but it shows no sign of friendship.",
        "You try to distract the creature, but it remains focused on you."
    ];

    public List<string> attack { get; } =
    [
        "You raise your weapon and charge at the enemy.",
        "You strike at the creature with all your strength.",
        "You attack before the enemy has a chance to react."
    ];
}

public class Trap
{
    public List<string> descriptions { get; } =
    [
        "The room looks strangely untouched. As you step inside, you notice several suspicious mechanisms hidden beneath the floor.",
        "Something feels wrong about this room. Small holes line the walls, and several stones appear slightly out of place.",
        "You enter a chamber filled with strange markings. The floor seems designed to punish anyone who walks across it carelessly."
    ];

    public TrapInteractions interactions { get; } = new();
}

public class TrapInteractions
{
    public List<string> proceed { get; } =
    [
        "You carefully move forward, watching every step.",
        "You slowly cross the room, trying to avoid anything suspicious.",
        "You hold your breath and make your way through the room."
    ];

    public List<string> observe { get; } =
    [
        "You carefully examine the floor and notice several pressure plates.",
        "You study the walls and discover tiny openings that could hide dangerous mechanisms.",
        "You inspect the room from a safe distance and identify several possible traps."
    ];

    public List<string> interact { get; } =
    [
        "You carefully examine one of the mechanisms and manage to disable it.",
        "You try to manipulate the mechanism without triggering it.",
        "You carefully move a suspicious stone. You hear a click, but nothing happens."
    ];

    public List<string> attack { get; } =
    [
        "You swing your weapon at a suspicious mechanism. The trap remains intact.",
        "You strike at the strange mechanism, but your attack does little.",
        "You attack the nearest suspicious object, hoping to disable the trap."
    ];
}

public class DeadEnd
{
    public List<string> descriptions { get; } =
    [
        "You reach the end of the path. A massive stone wall blocks your way. There is nowhere else to go.",
        "The corridor ends abruptly in a solid wall. Your journey comes to an unexpected end.",
        "You step into a small chamber and realize there is no exit. The path behind you has vanished into darkness."
    ];

    public DeadEndInteractions interactions { get; } = new();

    public List<string> gameOver { get; } =
    [
        "There is nowhere left to go. Your adventure ends here.",
        "The path has come to an end. Your journey is over.",
        "With no way forward, your adventure comes to an end."
    ];
}

public class DeadEndInteractions
{
    public List<string> proceed { get; } =
    [
        "You walk forward, but the wall brings you to a complete stop.",
        "You try to continue, but there is simply nowhere to go.",
        "You search for a way forward, but the path ends here."
    ];

    public List<string> observe { get; } =
    [
        "You carefully inspect the wall. There are no obvious passages or hidden doors.",
        "You examine every corner of the chamber, but find no way forward.",
        "You search for cracks, switches, or hidden mechanisms. Nothing reveals itself."
    ];

    public List<string> interact { get; } =
    [
        "You push against the wall. It does not move.",
        "You search the wall for a hidden mechanism, but find nothing.",
        "You run your hands across the stones. There is no secret passage."
    ];

    public List<string> attack { get; } =
    [
        "You strike the stone wall. Your weapon bounces off harmlessly.",
        "You attack the wall, but it barely reacts to the impact.",
        "You give the wall one final blow. It remains completely untouched."
    ];
}