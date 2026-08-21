namespace StatePatternRPG.Definitions;

public class RpgText
{
    public Rooms rooms { get; } = new();
}

public class Rooms
{
    public EmptyRoom empty { get; } = new();
    public EnemyRoom enemy { get; } = new();
    public TrapRoom trap { get; } = new();
    public GameOverRoom gameOver { get; } = new();
}

public class EmptyRoom
{
    public string description { get; } =
        "The room is quiet and empty. Dust covers the floor, and the faint sound of dripping water echoes through the walls.";

    public string proceed { get; } =
        "You move deeper into the dungeon.";

    public string observe { get; } =
        "You search the room carefully, but find nothing of value.";

    public string interact { get; } =
        "You touch the old stone wall. Nothing happens.";

    public string attack { get; } =
        "You swing your weapon through the empty air. There is nothing here to fight.";
}

public class EnemyRoom
{
    public string description { get; } =
        "A hostile creature emerges from the shadows. Its eyes lock onto you, and it prepares to attack.";

    public string proceed { get; } =
        "You try to move past the enemy, but he wounds you fataly. This is the end of your adventure.";

    public string observe { get; } =
        "You study your opponent carefully. It looks strong, but not invincible.";

    public string interact { get; } =
        "You attempt to communicate with the creature. It responds with an angry growl.";

    public string attack { get; } =
        "You raise your weapon and charge at the enemy.";
}

public class TrapRoom
{
    public string description { get; } =
        "The room looks strangely untouched. As you step inside, you notice several suspicious mechanisms hidden beneath the floor.";

    public string proceed { get; } =
        "You carefully move forward, watching every step. The trap is not disarmed and your journey comes to an end.";

    public string observe { get; } =
        "You carefully examine the floor and notice several pressure plates.";

    public string interact { get; } =
        "You carefully examine one of the mechanisms and manage to disable it.";

    public string attack { get; } =
        "You swing your weapon at a suspicious mechanism. The trap remains intact.";
}

public class GameOverRoom
{
    public string description { get; } =
        "You reach the end of the path. A massive stone wall blocks your way. There is nowhere else to go.";

    public string proceed { get; } =
        "There is nowhere left to go. Your adventure ends here.";

    public string observe { get; } =
        "You carefully inspect the wall. There are no obvious passages or hidden doors.";

    public string interact { get; } =
        "You push against the wall. It does not move.";

    public string attack { get; } =
        "You strike the stone wall. Your weapon bounces off harmlessly.";
}