namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsInspectorRulesPackagesState = { assignments: ResizeArray<aws.DataAwsInspectorRulesPackages.DataAwsInspectorRulesPackagesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/inspector_rules_packages">aws_inspector_rules_packages</a>.
    /// </summary>
    type DataAwsInspectorRulesPackagesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsInspectorRulesPackagesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsInspectorRulesPackagesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/inspector_rules_packages#id-1">DataAwsInspectorRulesPackages#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsInspectorRulesPackagesState, value: string) : DataAwsInspectorRulesPackagesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsInspectorRulesPackagesState

        member _.Run(state: DataAwsInspectorRulesPackagesState) : aws.DataAwsInspectorRulesPackages.DataAwsInspectorRulesPackages =
            let config = aws.DataAwsInspectorRulesPackages.DataAwsInspectorRulesPackagesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsInspectorRulesPackages.DataAwsInspectorRulesPackages(StackContext.get (), logicalId, config)
