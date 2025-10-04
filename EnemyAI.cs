using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float stopDistance = 2f;       // فاصله‌ای که دشمن متوقف می‌شود
    public float retreatDistance = 1f;    // فاصله‌ای که دشمن عقب می‌رود
    public float attackRate = 1f;         // زمان بین حمله‌ها
    private float nextAttackTime = 0f;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance > stopDistance)
        {
            // نزدیک شدن به بازیکن
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distance < retreatDistance)
        {
            // عقب رفتن از بازیکن
            Vector2 dir = transform.position - player.position;
            transform.position = Vector2.MoveTowards(transform.position, (Vector2)transform.position + dir, speed * Time.deltaTime);
        }

        // حمله اگر زمان حمله رسیده
        if (Time.time >= nextAttackTime && distance <= stopDistance)
        {
            AttackPlayer();
            nextAttackTime = Time.time + attackRate;
        }
    }

    void AttackPlayer()
    {
        // کد حمله به بازیکن (می‌تونه کاهش سلامتی یا شلیک گلوله باشد)
        Debug.L
