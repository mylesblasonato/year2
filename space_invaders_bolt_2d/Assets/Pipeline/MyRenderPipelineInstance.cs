using UnityEngine;
using UnityEngine.Rendering;

public class MyRenderPipelineInstance : RenderPipeline
{
    // Use this variable to a reference to the Render Pipeline Asset that was passed to the constructor
    private MyRenderPipelineAsset renderPipelineAsset;

    // The constructor has an instance of the ExampleRenderPipelineAsset class as its parameter.
    public MyRenderPipelineInstance(MyRenderPipelineAsset asset)
    {
        renderPipelineAsset = asset;
    }

    // Unity calls this method once per frame for each CameraType that is currently rendering.
    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        // This is an example of using the data from the Render Pipeline Asset.
        Debug.Log(renderPipelineAsset.exampleString);

        // This is where you can write custom rendering code. Customize this method to customize your SRP.
    }
}
