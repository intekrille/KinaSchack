using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Piece { Invalid, Empty, Red, Green, Blue, Yellow, Purple, Orange };

public class InstantiateBoard : MonoBehaviour
{
    private const int maxRow = 17;
    private const int maxColumn = 13;

    [SerializeField]
    private float offsetX = 0.75F;
    [SerializeField]
    private float offsetY = 0.75F;
    [SerializeField]
    private float offsetUnevenRows = 0.5F;

    [SerializeField]
    GameObject emptyPrefab;
    [SerializeField]
    GameObject redPrefab;
    [SerializeField]
    GameObject bluePrefab;
    [SerializeField]
    GameObject greenPrefab;
    [SerializeField]
    GameObject yellowPrefab;
    [SerializeField]
    GameObject purplePrefab;
    [SerializeField]
    GameObject orangePrefab;
    [SerializeField]
    GameObject menu;

    GameObject prefab;


    Piece[,] board = new Piece[maxRow, maxColumn]
    {
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
    },
    {
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid
    },
    {
        Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid,
    },
    {
        Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid,  Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid,  Piece.Invalid,
    },
    {
        Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,  Piece.Empty,  Piece.Empty,
        Piece.Invalid, Piece.Invalid,
    },
    {
        Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,  Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid,
    },
    {
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid
    },
    {
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
    },
    // Top
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty, Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    {
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid,
        Piece.Empty,
        Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid, Piece.Invalid
    },
    };

    /// <summary>
    /// Loops through all elements in the "board"-array and instantiates them.
    /// </summary>
    private void InstantiateLoop()
    {
        for (int x = 0; x < maxRow; x++)
        {
            for (int y = 0; y < maxColumn; y++)
            {
                if (board[x, y] != Piece.Invalid)
                {
                    DifferentColors(x, y);
                    // Generate pieces with every other row having an offset.
                    if (x % 2 == 0)
                    {
                        Instantiate(prefab, new Vector2(y * offsetY, x * offsetX), Quaternion.Euler(90, 0, 0));
                    }
                    else
                    {
                        Instantiate(prefab, new Vector2(y * offsetY + offsetUnevenRows, x * offsetX), Quaternion.Euler(90, 0, 0));
                    }
                }
            }
        }

    }
    /// <summary>
    /// Checks what color that should be instantiated.
    /// </summary>
    private void DifferentColors(int x, int y)
    {
        switch (board[x, y])
        {
            case Piece.Empty:
                prefab = emptyPrefab;
                break;
            case Piece.Red:
                prefab = redPrefab;
                break;
            case Piece.Blue:
                prefab = bluePrefab;
                break;
            case Piece.Orange:
                prefab = orangePrefab;
                break;
            case Piece.Purple:
                prefab = purplePrefab;
                break;
            case Piece.Green:
                prefab = greenPrefab;
                break;
            case Piece.Yellow:
                prefab = yellowPrefab;
                break;
        }
    }

    /// <summary>
    /// The buttons changes colors of the tips, depending on how many players that are chosen.
    /// </summary>
    public void TwoPlayerButton()
    {
        BottomRed();
        board[4, 4] = Piece.Red;
        board[4, 5] = Piece.Red;
        board[4, 6] = Piece.Red;
        board[4, 7] = Piece.Red;
        board[4, 8] = Piece.Red;
        TopBlue();
        board[12, 4] = Piece.Blue;
        board[12, 5] = Piece.Blue;
        board[12, 6] = Piece.Blue;
        board[12, 7] = Piece.Blue;
        board[12, 8] = Piece.Blue;

        InstantiateLoop();
        Destroy(menu);
    }
    public void ThreePlayerButton()
    {
        BottomRed();
        UpLeftPurple();
        UpRightOrange();
        InstantiateLoop();
        Destroy(menu);
    }
    public void FourPlayerButton()
    {
        BottomRed();
        TopBlue();
        LowLeftGreen();
        UpRightOrange();
        InstantiateLoop();
        Destroy(menu);
    }
    public void SixPlayerButton()
    {
        BottomRed();
        TopBlue();
        LowLeftGreen();
        LowRightYellow();
        UpLeftPurple();
        UpRightOrange();
        InstantiateLoop();
        Destroy(menu);
    }

    /// <summary>
    /// Changes the colors of the tips of the star
    /// </summary>
    public void BottomRed()
    {
        // Bottom
        board[0, 6] = Piece.Red;
        board[1, 5] = Piece.Red;
        board[1, 6] = Piece.Red;
        board[2, 5] = Piece.Red;
        board[2, 6] = Piece.Red;
        board[2, 7] = Piece.Red;
        board[3, 4] = Piece.Red;
        board[3, 5] = Piece.Red;
        board[3, 6] = Piece.Red;
        board[3, 7] = Piece.Red;
    }
    public void TopBlue()
    {
        // Top
        board[16, 6] = Piece.Blue;
        board[15, 5] = Piece.Blue;
        board[15, 6] = Piece.Blue;
        board[14, 5] = Piece.Blue;
        board[14, 6] = Piece.Blue;
        board[14, 7] = Piece.Blue;
        board[13, 4] = Piece.Blue;
        board[13, 5] = Piece.Blue;
        board[13, 6] = Piece.Blue;
        board[13, 7] = Piece.Blue;
    }
    private void LowLeftGreen()
    {
        // Lower Left
        board[4, 0] = Piece.Green;
        board[4, 1] = Piece.Green;
        board[4, 2] = Piece.Green;
        board[4, 3] = Piece.Green;
        board[5, 0] = Piece.Green;
        board[5, 1] = Piece.Green;
        board[5, 2] = Piece.Green;
        board[6, 1] = Piece.Green;
        board[6, 2] = Piece.Green;
        board[7, 1] = Piece.Green;
    }
    private void LowRightYellow()
    {
        // Lower Right
        board[4, 9]  = Piece.Yellow;
        board[4, 10] = Piece.Yellow;
        board[4, 11] = Piece.Yellow;
        board[4, 12] = Piece.Yellow;
        board[5, 9] = Piece.Yellow;
        board[5, 10] = Piece.Yellow;
        board[5, 11] = Piece.Yellow;
        board[6, 10] = Piece.Yellow;
        board[6, 11] = Piece.Yellow;
        board[7, 10] = Piece.Yellow;
    }
    private void UpLeftPurple()
    {
        // Upper Left
        board[9, 1] = Piece.Purple;
        board[10, 1] = Piece.Purple;
        board[10, 2] = Piece.Purple;
        board[11, 0] = Piece.Purple;
        board[11, 1] = Piece.Purple;
        board[11, 2] = Piece.Purple;
        board[12, 0] = Piece.Purple;
        board[12, 1] = Piece.Purple;
        board[12, 2] = Piece.Purple;
        board[12, 3] = Piece.Purple;
    }
    private void UpRightOrange()
    {
        // Upper Right
        board[9, 10] = Piece.Orange;
        board[10, 10] = Piece.Orange;
        board[10, 11] = Piece.Orange;
        board[11, 9]  = Piece.Orange;
        board[11, 10] = Piece.Orange;
        board[11, 11] = Piece.Orange;
        board[12, 9]  = Piece.Orange;
        board[12, 10] = Piece.Orange;
        board[12, 11] = Piece.Orange;
        board[12, 12] = Piece.Orange;
    }
}