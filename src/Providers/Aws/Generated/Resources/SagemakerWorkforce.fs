namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerWorkforceState<'WorkforceName> = { assignments: ResizeArray<aws.SagemakerWorkforce.SagemakerWorkforceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce">aws_sagemaker_workforce</a>.
    /// </summary>
    type SagemakerWorkforceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerWorkforceState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerWorkforceState<Missing>)

        member _.Zero(()) : SagemakerWorkforceState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerWorkforceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_name-1">SagemakerWorkforce#workforce_name</a>.
        /// </summary>
        [<CustomOperation "workforce_name">]
        member _.WorkforceName(state: SagemakerWorkforceState<Missing>, value: string) : SagemakerWorkforceState<Present> =
            state.assignments.Add(fun config -> config.WorkforceName <- value)
            ({ assignments = state.assignments } : SagemakerWorkforceState<Present>)

        /// <summary>
        /// cognito_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#cognito_config-1">SagemakerWorkforce#cognito_config</a>
        /// </summary>
        [<CustomOperation "cognito_config">]
        member _.CognitoConfig(state: SagemakerWorkforceState<'WorkforceName>, value: aws.SagemakerWorkforce.SagemakerWorkforceCognitoConfig) : SagemakerWorkforceState<'WorkforceName> =
            state.assignments.Add(fun config -> config.CognitoConfig <- value)
            state : SagemakerWorkforceState<'WorkforceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#id-1">SagemakerWorkforce#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerWorkforceState<'WorkforceName>, value: string) : SagemakerWorkforceState<'WorkforceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerWorkforceState<'WorkforceName>

        /// <summary>
        /// oidc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#oidc_config-1">SagemakerWorkforce#oidc_config</a>
        /// </summary>
        [<CustomOperation "oidc_config">]
        member _.OidcConfig(state: SagemakerWorkforceState<'WorkforceName>, value: aws.SagemakerWorkforce.SagemakerWorkforceOidcConfig) : SagemakerWorkforceState<'WorkforceName> =
            state.assignments.Add(fun config -> config.OidcConfig <- value)
            state : SagemakerWorkforceState<'WorkforceName>

        /// <summary>
        /// source_ip_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#source_ip_config-1">SagemakerWorkforce#source_ip_config</a>
        /// </summary>
        [<CustomOperation "source_ip_config">]
        member _.SourceIpConfig(state: SagemakerWorkforceState<'WorkforceName>, value: aws.SagemakerWorkforce.SagemakerWorkforceSourceIpConfig) : SagemakerWorkforceState<'WorkforceName> =
            state.assignments.Add(fun config -> config.SourceIpConfig <- value)
            state : SagemakerWorkforceState<'WorkforceName>

        /// <summary>
        /// workforce_vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#workforce_vpc_config-1">SagemakerWorkforce#workforce_vpc_config</a>
        /// </summary>
        [<CustomOperation "workforce_vpc_config">]
        member _.WorkforceVpcConfig(state: SagemakerWorkforceState<'WorkforceName>, value: aws.SagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfig) : SagemakerWorkforceState<'WorkforceName> =
            state.assignments.Add(fun config -> config.WorkforceVpcConfig <- value)
            state : SagemakerWorkforceState<'WorkforceName>

        member _.Run(state: SagemakerWorkforceState<Present>) : aws.SagemakerWorkforce.SagemakerWorkforce =
            let config = aws.SagemakerWorkforce.SagemakerWorkforceConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerWorkforce.SagemakerWorkforce(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerWorkforce: missing required arguments. Must call: workforce_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerWorkforceState<_>) : aws.SagemakerWorkforce.SagemakerWorkforce =
            Unchecked.defaultof<aws.SagemakerWorkforce.SagemakerWorkforce>
