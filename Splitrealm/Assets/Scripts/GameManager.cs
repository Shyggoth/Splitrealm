using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CameraMovement cameraMovement;
    public RoadManager roadManager;
    public InputManager inputManager;
    public UIController uiController;
    public StructureManager structureManager;

    void Start()
    {
        uiController.OnRoadPlacement += RoadPlacementHandler;
        uiController.OnHousePlacement += HousePlacementHandler;
        uiController.OnSpecialPlacement += SpecialPlacementHandler;
    }

    void SpecialPlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceSpecial;
    }

    void HousePlacementHandler()
    {
        ClearInputActions();
        inputManager.OnMouseClick += structureManager.PlaceHouse;
    }

    void RoadPlacementHandler()
    {
        ClearInputActions();

        inputManager.OnMouseClick += roadManager.PlaceRoad;
        inputManager.OnMouseHold += roadManager.PlaceRoad;
        inputManager.OnMouseUp += roadManager.FinishPlacingRoad;
    }

    void ClearInputActions()
    {
        inputManager.OnMouseClick = null;
        inputManager.OnMouseHold = null;
        inputManager.OnMouseUp = null;
    }

    void Update()
    {
        cameraMovement.MoveCamera(new Vector3(inputManager.CameraMovementVector.x,0, inputManager.CameraMovementVector.y));
    }
}