import React from 'react';
import List from '@mui/material/List';
import items from "./sidebar-items-list";
import SidebarListItem from "./list-item";
import SidebarListItemGroup from "./list-item-group";

export default function MainMenu() {
    const [open, setOpen] = React.useState(true);

    const handleClick = () => {
        setOpen(!open);
    };

    let itemsList = items.map((item, index) => {
        if (item.items) {
            return (
                <SidebarListItemGroup
                    key={index}
                    text={item.text}
                    icon={item.icon}
                    items={item.items}
                />
            );
        }

        return (
            <SidebarListItem
                key={index}
                text={item.text}
                icon={item.icon}
                route={item.route}
            />
        );
    });

    return (
        <List
            sx={{ width: '100%', maxWidth: 360, bgcolor: 'background.paper' }}
            component="nav"
            aria-labelledby="nested-list-subheader"
        >
            {itemsList}
        </List>
    );
}
