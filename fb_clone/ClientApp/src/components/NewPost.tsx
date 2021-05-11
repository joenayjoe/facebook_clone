import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import React from "react";
import { Card, CardBody, CardFooter } from "reactstrap";
import Avatar from "./Avatar";

interface IProp extends React.HtmlHTMLAttributes<HTMLAnchorElement> {
    newPostHandler: () => void;
}
const NewPost: React.FunctionComponent<IProp> = props => {
    const { newPostHandler } = props;
    return (
        <Card>
            <CardBody className="new-post-top">
                <Avatar width="40px" height="40px" url="https://avatars.githubusercontent.com/u/4953463?v=4" />
                <div className="new-post-input-div" onClick={newPostHandler}>What's on your mind, Junaid?</div>
            </CardBody>
            <CardFooter className="d-flex justify-content-between">
                <div className="hoverable-nav-link p-2">
                    <FontAwesomeIcon icon="images" />
                    <h6 className="mx-2 my-0">Photo/Video</h6>
                </div>
                <div className="hoverable-nav-link p-2">
                    <FontAwesomeIcon icon="user-tag" />
                    <h6 className="mx-2 my-0">Tag Friend</h6>
                </div>
                <div className="hoverable-nav-link p-2">
                    <FontAwesomeIcon icon="smile" />
                    <h6 className="mx-2 my-0">Feeling/Activity</h6>
                </div>
            </CardFooter>
        </Card>
    );
}
export default NewPost;