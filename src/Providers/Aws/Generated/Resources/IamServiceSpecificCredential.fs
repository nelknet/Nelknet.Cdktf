namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamServiceSpecificCredentialState<'ServiceName, 'UserName> = { assignments: ResizeArray<aws.IamServiceSpecificCredential.IamServiceSpecificCredentialConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_specific_credential">aws_iam_service_specific_credential</a>.
    /// </summary>
    type IamServiceSpecificCredentialBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamServiceSpecificCredentialState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamServiceSpecificCredentialState<Missing, Missing>)

        member _.Zero(()) : IamServiceSpecificCredentialState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamServiceSpecificCredentialState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_specific_credential#service_name-1">IamServiceSpecificCredential#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: IamServiceSpecificCredentialState<Missing, 'UserName>, value: string) : IamServiceSpecificCredentialState<Present, 'UserName> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : IamServiceSpecificCredentialState<Present, 'UserName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_specific_credential#user_name-1">IamServiceSpecificCredential#user_name</a>.
        /// </summary>
        [<CustomOperation "user_name">]
        member _.UserName(state: IamServiceSpecificCredentialState<'ServiceName, Missing>, value: string) : IamServiceSpecificCredentialState<'ServiceName, Present> =
            state.assignments.Add(fun config -> config.UserName <- value)
            ({ assignments = state.assignments } : IamServiceSpecificCredentialState<'ServiceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_specific_credential#id-1">IamServiceSpecificCredential#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamServiceSpecificCredentialState<'ServiceName, 'UserName>, value: string) : IamServiceSpecificCredentialState<'ServiceName, 'UserName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamServiceSpecificCredentialState<'ServiceName, 'UserName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_service_specific_credential#status-1">IamServiceSpecificCredential#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: IamServiceSpecificCredentialState<'ServiceName, 'UserName>, value: string) : IamServiceSpecificCredentialState<'ServiceName, 'UserName> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : IamServiceSpecificCredentialState<'ServiceName, 'UserName>

        member _.Run(state: IamServiceSpecificCredentialState<Present, Present>) : aws.IamServiceSpecificCredential.IamServiceSpecificCredential =
            let config = aws.IamServiceSpecificCredential.IamServiceSpecificCredentialConfig()
            for setter in state.assignments do
                setter config
            aws.IamServiceSpecificCredential.IamServiceSpecificCredential(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamServiceSpecificCredential: missing required arguments. Must call: service_name, user_name.", 9999, IsError = true)>]
        member _.Run(_: IamServiceSpecificCredentialState<_, _>) : aws.IamServiceSpecificCredential.IamServiceSpecificCredential =
            Unchecked.defaultof<aws.IamServiceSpecificCredential.IamServiceSpecificCredential>
