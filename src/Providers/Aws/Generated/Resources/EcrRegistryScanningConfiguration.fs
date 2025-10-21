namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcrRegistryScanningConfigurationState<'ScanType> = { assignments: ResizeArray<aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration">aws_ecr_registry_scanning_configuration</a>.
    /// </summary>
    type EcrRegistryScanningConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcrRegistryScanningConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EcrRegistryScanningConfigurationState<Missing>)

        member _.Zero(()) : EcrRegistryScanningConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EcrRegistryScanningConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#scan_type-1">EcrRegistryScanningConfiguration#scan_type</a>.
        /// </summary>
        [<CustomOperation "scan_type">]
        member _.ScanType(state: EcrRegistryScanningConfigurationState<Missing>, value: string) : EcrRegistryScanningConfigurationState<Present> =
            state.assignments.Add(fun config -> config.ScanType <- value)
            ({ assignments = state.assignments } : EcrRegistryScanningConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#id-1">EcrRegistryScanningConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcrRegistryScanningConfigurationState<'ScanType>, value: string) : EcrRegistryScanningConfigurationState<'ScanType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcrRegistryScanningConfigurationState<'ScanType>

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecr_registry_scanning_configuration#rule-1">EcrRegistryScanningConfiguration#rule</a> Accepts: aws.IResolvable | aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfigurationRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: EcrRegistryScanningConfigurationState<'ScanType>, value: HashiCorp.Cdktf.IResolvable) : EcrRegistryScanningConfigurationState<'ScanType> =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : EcrRegistryScanningConfigurationState<'ScanType>

        member _.Run(state: EcrRegistryScanningConfigurationState<Present>) : aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfiguration =
            let config = aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecrRegistryScanningConfiguration: missing required arguments. Must call: scan_type.", 9999, IsError = true)>]
        member _.Run(_: EcrRegistryScanningConfigurationState<_>) : aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfiguration =
            Unchecked.defaultof<aws.EcrRegistryScanningConfiguration.EcrRegistryScanningConfiguration>
