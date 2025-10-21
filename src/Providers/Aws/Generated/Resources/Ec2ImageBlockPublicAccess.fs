namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2ImageBlockPublicAccessState<'State> = { assignments: ResizeArray<aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access">aws_ec2_image_block_public_access</a>.
    /// </summary>
    type Ec2ImageBlockPublicAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2ImageBlockPublicAccessState<Missing> =
            ({ assignments = ResizeArray() } : Ec2ImageBlockPublicAccessState<Missing>)

        member _.Zero(()) : Ec2ImageBlockPublicAccessState<Missing> =
            ({ assignments = ResizeArray() } : Ec2ImageBlockPublicAccessState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#state-1">Ec2ImageBlockPublicAccess#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: Ec2ImageBlockPublicAccessState<Missing>, value: string) : Ec2ImageBlockPublicAccessState<Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : Ec2ImageBlockPublicAccessState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#id-1">Ec2ImageBlockPublicAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2ImageBlockPublicAccessState<'State>, value: string) : Ec2ImageBlockPublicAccessState<'State> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2ImageBlockPublicAccessState<'State>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#timeouts-1">Ec2ImageBlockPublicAccess#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2ImageBlockPublicAccessState<'State>, value: aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessTimeouts) : Ec2ImageBlockPublicAccessState<'State> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2ImageBlockPublicAccessState<'State>

        member _.Run(state: Ec2ImageBlockPublicAccessState<Present>) : aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccess =
            let config = aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2ImageBlockPublicAccess: missing required arguments. Must call: state.", 9999, IsError = true)>]
        member _.Run(_: Ec2ImageBlockPublicAccessState<_>) : aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccess =
            Unchecked.defaultof<aws.Ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccess>
