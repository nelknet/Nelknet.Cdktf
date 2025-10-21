namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlueScriptState<'DagEdge, 'DagNode> = { assignments: ResizeArray<aws.DataAwsGlueScript.DataAwsGlueScriptConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script">aws_glue_script</a>.
    /// </summary>
    type DataAwsGlueScriptBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlueScriptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueScriptState<Missing, Missing>)

        member _.Zero(()) : DataAwsGlueScriptState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueScriptState<Missing, Missing>)

        /// <summary>
        /// dag_edge block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#dag_edge-1">DataAwsGlueScript#dag_edge</a> Accepts: aws.IResolvable | aws.DataAwsGlueScript.DataAwsGlueScriptDagEdge[]
        /// </summary>
        [<CustomOperation "dag_edge">]
        member _.DagEdge(state: DataAwsGlueScriptState<Missing, 'DagNode>, value: HashiCorp.Cdktf.IResolvable) : DataAwsGlueScriptState<Present, 'DagNode> =
            state.assignments.Add(fun config -> config.DagEdge <- value)
            ({ assignments = state.assignments } : DataAwsGlueScriptState<Present, 'DagNode>)

        /// <summary>
        /// dag_node block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#dag_node-1">DataAwsGlueScript#dag_node</a> Accepts: aws.IResolvable | aws.DataAwsGlueScript.DataAwsGlueScriptDagNode[]
        /// </summary>
        [<CustomOperation "dag_node">]
        member _.DagNode(state: DataAwsGlueScriptState<'DagEdge, Missing>, value: HashiCorp.Cdktf.IResolvable) : DataAwsGlueScriptState<'DagEdge, Present> =
            state.assignments.Add(fun config -> config.DagNode <- value)
            ({ assignments = state.assignments } : DataAwsGlueScriptState<'DagEdge, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#id-1">DataAwsGlueScript#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGlueScriptState<'DagEdge, 'DagNode>, value: string) : DataAwsGlueScriptState<'DagEdge, 'DagNode> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGlueScriptState<'DagEdge, 'DagNode>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#language-1">DataAwsGlueScript#language</a>.
        /// </summary>
        [<CustomOperation "language">]
        member _.Language(state: DataAwsGlueScriptState<'DagEdge, 'DagNode>, value: string) : DataAwsGlueScriptState<'DagEdge, 'DagNode> =
            state.assignments.Add(fun config -> config.Language <- value)
            state : DataAwsGlueScriptState<'DagEdge, 'DagNode>

        member _.Run(state: DataAwsGlueScriptState<Present, Present>) : aws.DataAwsGlueScript.DataAwsGlueScript =
            let config = aws.DataAwsGlueScript.DataAwsGlueScriptConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlueScript.DataAwsGlueScript(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGlueScript: missing required arguments. Must call: dag_edge, dag_node.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGlueScriptState<_, _>) : aws.DataAwsGlueScript.DataAwsGlueScript =
            Unchecked.defaultof<aws.DataAwsGlueScript.DataAwsGlueScript>
