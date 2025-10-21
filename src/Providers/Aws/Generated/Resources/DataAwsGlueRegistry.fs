namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGlueRegistryState<'Name> = { assignments: ResizeArray<aws.DataAwsGlueRegistry.DataAwsGlueRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_registry">aws_glue_registry</a>.
    /// </summary>
    type DataAwsGlueRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGlueRegistryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueRegistryState<Missing>)

        member _.Zero(()) : DataAwsGlueRegistryState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGlueRegistryState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_registry#name-1">DataAwsGlueRegistry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsGlueRegistryState<Missing>, value: string) : DataAwsGlueRegistryState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsGlueRegistryState<Present>)

        member _.Run(state: DataAwsGlueRegistryState<Present>) : aws.DataAwsGlueRegistry.DataAwsGlueRegistry =
            let config = aws.DataAwsGlueRegistry.DataAwsGlueRegistryConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGlueRegistry.DataAwsGlueRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGlueRegistry: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGlueRegistryState<_>) : aws.DataAwsGlueRegistry.DataAwsGlueRegistry =
            Unchecked.defaultof<aws.DataAwsGlueRegistry.DataAwsGlueRegistry>
