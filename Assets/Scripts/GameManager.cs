using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Tree<string> familyTree;

    private void Start()
    {
        familyTree = new Tree<string>("Edmund (Abuelo)");


        var madre = new TreeNode<string>("Daphe (madre)");
        var tio = new TreeNode<string>("Colin (tio)");

        familyTree.Root.AddChild(madre);
        familyTree.Root.AddChild(tio);

        var hija = new TreeNode<string>("Amelia(hija)");
        var prima = new TreeNode<string>("Agatha(prima)");

        madre.AddChild(hija);
        tio.AddChild(prima);


        var hijo1 = new TreeNode<string>("Tomas (Hijo 1)");
        var hijo2 = new TreeNode<string>("Charles (Hijo 2)");

        hija.AddChild(hijo1);
        hija.AddChild(hijo2);

        Debug.Log("Recorrido Preorden del árbol genealógico:");
        familyTree.TraversePreOrder(familyTree.Root, var => Debug.Log(var));

        int height = familyTree.GetHeight(familyTree.Root);
        Debug.Log("Altura del árbol genealógico: " + height);

    }


}
