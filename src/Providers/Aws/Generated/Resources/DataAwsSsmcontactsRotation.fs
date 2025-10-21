namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsmcontactsRotationState<'Arn> = { assignments: ResizeArray<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_rotation">aws_ssmcontacts_rotation</a>.
    /// </summary>
    type DataAwsSsmcontactsRotationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsmcontactsRotationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsRotationState<Missing>)

        member _.Zero(()) : DataAwsSsmcontactsRotationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsmcontactsRotationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssmcontacts_rotation#arn-1">DataAwsSsmcontactsRotation#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsSsmcontactsRotationState<Missing>, value: string) : DataAwsSsmcontactsRotationState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsSsmcontactsRotationState<Present>)

        member _.Run(state: DataAwsSsmcontactsRotationState<Present>) : aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotation =
            let config = aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsmcontactsRotation: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsmcontactsRotationState<_>) : aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotation =
            Unchecked.defaultof<aws.DataAwsSsmcontactsRotation.DataAwsSsmcontactsRotation>
