namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOamLinksState = { assignments: ResizeArray<aws.DataAwsOamLinks.DataAwsOamLinksConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_links">aws_oam_links</a>.
    /// </summary>
    type DataAwsOamLinksBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOamLinksState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsOamLinksState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/oam_links#id-1">DataAwsOamLinks#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOamLinksState, value: string) : DataAwsOamLinksState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOamLinksState

        member _.Run(state: DataAwsOamLinksState) : aws.DataAwsOamLinks.DataAwsOamLinks =
            let config = aws.DataAwsOamLinks.DataAwsOamLinksConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOamLinks.DataAwsOamLinks(StackContext.get (), logicalId, config)
