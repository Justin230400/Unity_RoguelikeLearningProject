using UnityEngine;

static public class Action
{
    static public void EscapeAction()
    {
        // Application.Quit()
        Debug.Log("Quit"); 
    }

    static public void MovementAction(Entity entity, Vector2 direction)
    {
        // Debug.Log($"{entity.name} move {direction}!");
        entity.Move(direction);
        GameManager.instance.EndTurn();
    }

    static public void SkipAction(Entity entity)
    {
        Debug.Log($"{entity.name} skipped their turn!");
        GameManager.instance.EndTurn();
    }
}