// Because Key-value pair store ho rha toh isko store ke liye hum LL use krenge
// And usko store ke liye ek aur LL use krenge
// two LL hasbeen use here

class ListNode
{
    public int key, value;
    public ListNode next;

    public ListNode(int key, int value, ListNode next)
    {
        this.key = key;
        this.value = value;
        this.next = next;
    }

    public ListNode()
    {
        this.key = -1;
        this.value = -1;
        this.next = null;
    }
}



public class MyHashMap {
    private ListNode[] map;  
    public MyHashMap() {
        map=new ListNode[1000]; //Length apne upar hai.
        for(int i=0;i<1000;i++)
        {
            map[i]=new ListNode();    // Har node ko dummy/head Node denge
         }
    }
    
    //Special Fucntion=hash Fnct
    //Division method

    private int GetIndex(int key)
    {
        return key % 1000;
    }

    public void Put(int key, int value) {

        int index=GetIndex(key); // Isse Index milega
        ListNode curr=map[index]; //This will point to my Index

        while(curr!=null)  //Loop jabtk chalega jaha tak data ho
        {
            if(curr.key==key) //Checks key present hai ya nahi
            {
                curr.value=value; //Agar hai toh value update krddo
                return;
            }

            if(curr.next==null)
            {
                break;
            }
            curr=curr.next;
        }
        curr.next=new ListNode(key,value,null);
    }
    
    public int Get(int key) {
        int index=GetIndex(key);
        ListNode curr=map[index].next;
        while(curr!=null)
        {
            if(curr.key==key)
            {
                return curr.value;
            }
            curr=curr.next;
        }
        return -1;       
    }
    
   public void Remove(int key)
{
    int index = GetIndex(key);
    ListNode curr = map[index];

    while (curr.next != null)
    {
        if (curr.next.key == key)
        {
            curr.next = curr.next.next; // 
            return;
        }
        curr = curr.next;
    }
}
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
