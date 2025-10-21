namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOutpostsOutpostInstanceTypesState<'Arn> = { assignments: ResizeArray<aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_types">aws_outposts_outpost_instance_types</a>.
    /// </summary>
    type DataAwsOutpostsOutpostInstanceTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOutpostsOutpostInstanceTypesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsOutpostInstanceTypesState<Missing>)

        member _.Zero(()) : DataAwsOutpostsOutpostInstanceTypesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOutpostsOutpostInstanceTypesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_types#arn-1">DataAwsOutpostsOutpostInstanceTypes#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsOutpostsOutpostInstanceTypesState<Missing>, value: string) : DataAwsOutpostsOutpostInstanceTypesState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsOutpostsOutpostInstanceTypesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/outposts_outpost_instance_types#id-1">DataAwsOutpostsOutpostInstanceTypes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOutpostsOutpostInstanceTypesState<'Arn>, value: string) : DataAwsOutpostsOutpostInstanceTypesState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOutpostsOutpostInstanceTypesState<'Arn>

        member _.Run(state: DataAwsOutpostsOutpostInstanceTypesState<Present>) : aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypes =
            let config = aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOutpostsOutpostInstanceTypes: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOutpostsOutpostInstanceTypesState<_>) : aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypes =
            Unchecked.defaultof<aws.DataAwsOutpostsOutpostInstanceTypes.DataAwsOutpostsOutpostInstanceTypes>
